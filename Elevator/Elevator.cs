using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Elevator
{
    public partial class Elevator : Form
    {
        public delegate void ElevatorEventHandler(object source, EventArgs e, int number);
        public event ElevatorEventHandler floorReached;
        public event ElevatorEventHandler floorRequest;
        public event ElevatorEventHandler logRequest;

        private Boolean doorsOpen;
        private Boolean programActive;
        private Timer timer;
        private Logger logger;
        private DataSet dataSet;
        private BackgroundWorker worker;

        private int requestedFloor;
        private int currentFloor;
        private int xScaleElevatorLeftDoor;
        private int xScaleElevatorRightDoor;
        private int yScaleElevatorLeftDoor;
        private int yScaleElevatorRightDoor;

        private int yScaleElevatorBox;

        private int leftDoorClosed;
        private int leftDoorOpen;
        private int elevatorPositionFirstFloor;
        private int elevatorPositionGroundFloor;

        //==================================================================================================
        //Elevator constructor class
        public Elevator()
        {
            InitializeComponent();
            logger = new Logger();
            worker = new BackgroundWorker();
            dataSet = new DataSet();

            floorReached += new ElevatorEventHandler(OnFloorReached);
            floorRequest += new ElevatorEventHandler(OnFloorRequest);
            logRequest += new ElevatorEventHandler(OnLogRequest);

            doorsOpen = false;
            programActive = false;
            requestedFloor = 0;
            currentFloor = 0;

            //Elevator scale values to be used when moving objects
            leftDoorClosed = 15;
            leftDoorOpen = -59;
            elevatorPositionFirstFloor = 20;
            elevatorPositionGroundFloor = 214;
            xScaleElevatorLeftDoor = elevatorLeftDoor.Location.X;
            xScaleElevatorRightDoor = elevatorRightDoor.Location.X;
            yScaleElevatorBox = elevatorBox.Location.Y;

            dataSet = logger.GetData();
            TimedDatabaseUpdate();
        }
        //==================================================================================================
        //Method responsible for handling floorReached event - requests TimerSetting to open doors,
        //puts through a log request and updates elevator location displays on floors
        protected virtual void OnFloorReached(object source, EventArgs e, int floorNo)
        {
            if (floorReached != null)
            {
                TimerSetting(1, currentFloor);
                currentFloor = floorNo;
                ResetButtonColours();
                if (floorNo != -1)
                {
                    logRequest(this, EventArgs.Empty, floorNo);
                }
                if (currentFloor == 0)
                {
                    groundFloorCallLabel.Text = "G";
                    firstFloorCallLabel.Text = "G";
                }
                else
                {
                    groundFloorCallLabel.Text = "1";
                    firstFloorCallLabel.Text = "1";
                }
            }
        }
        //==================================================================================================
        //Method responsible for handling request event - requests TimerSetting to close the doors and move 
        //the elevator to user-requested floor
        protected virtual async void OnFloorRequest(object source, EventArgs e, int floorRequested)
        {
            if (floorRequest != null)
            {
                if (doorsOpen)
                {
                    TimerSetting(2, floorRequested);
                }
                while (doorsOpen)
                {
                    await Task.Delay(800);
                }
                TimerSetting(3, floorRequested);
            }
        }
        //==================================================================================================
        //Method responsible for logging events - Creats different logs depending on logCode
        protected virtual void OnLogRequest(object source, EventArgs e, int logCode)
        {
            try
            {
                if (logRequest != null)
                {
                    string currentDateTime = DateTime.Now.ToString();
                    string logText = "";
                    switch (logCode)
                    {
                        case 0:
                            //elevator reached G floor
                            logText = "Elevator is on ground floor";
                            break;
                        case 1:
                            //elevator reached 1 floor
                            logText = "Elevator is on first floor";
                            break;
                        case 2:
                            //elevator is opening doors
                            logText = "Doors open";
                            break;
                        case 3:
                            //elevator is closing doors
                            logText = "Doors closed";
                            break;
                        case 4:
                            //G floor request button press
                            logText = "Ground floor request made";
                            break;
                        case 5:
                            //1 floor request button press
                            logText = "First floor request made";
                            break;
                        case 6:
                            //get data button press
                            logText = "Get log data request made";
                            break;
                        case 7:
                            //update database button press
                            logText = "Update database request made";
                            break;
                    }
                    DataRow row = dataSet.Tables["elevatorlogs"].NewRow();

                    row["logDate"] = currentDateTime;
                    row["logText"] = logText;
                    dataSet.Tables["elevatorlogs"].Rows.Add(row);
                }
            }
            catch (NullReferenceException ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }
        //==================================================================================================
        //Timer setting - Assigns different tasks to the timer.Tick
        private void TimerSetting(int optionNo, int floorNo)
        {
            timer = new Timer();
            switch (optionNo)
            {
                case 1:
                    //Open Doors
                    timer.Tick += new EventHandler(OpenDoors);
                    timer.Interval = 18;
                    break;
                case 2:
                    //Close Doors
                    timer.Tick += new EventHandler(CloseDoors);
                    timer.Interval = 18;
                    break;
                case 3:
                    //Move Elevator Up
                    timer.Tick += (sender, args) => MoveElevator(floorNo);
                    timer.Interval = 24;
                    break;
            }
            timer.Enabled = true;
        }
        //==================================================================================================
        //Remove timer
        private void RemoveTimer()
        {
            timer.Dispose();
        }
        //==================================================================================================
        //Open doors, CloseDoors after a 2 second delay
        private async void OpenDoors(object sender, EventArgs e)
        {
            if (xScaleElevatorLeftDoor > leftDoorOpen)
            {
                elevatorLeftDoor.Location = new Point(xScaleElevatorLeftDoor -= 1, yScaleElevatorLeftDoor);
                elevatorRightDoor.Location = new Point(xScaleElevatorRightDoor += 1, yScaleElevatorRightDoor);
            }
            else
            {
                if (!doorsOpen)
                {
                    logRequest(this, EventArgs.Empty, 2);
                }
                doorsOpen = true;
                RemoveTimer();
                programActive = false;
            }
            if (!programActive)
            {
                await Task.Delay(2000);
                if (!programActive)
                {
                    programActive = true;
                    TimerSetting(2, currentFloor);
                }
            }
        }
        //==================================================================================================
        //Close doors 
        private void CloseDoors(object sender, EventArgs e)
        {
            if (xScaleElevatorLeftDoor < leftDoorClosed)
            {
                elevatorLeftDoor.Location = new Point(xScaleElevatorLeftDoor += 1, yScaleElevatorLeftDoor);
                elevatorRightDoor.Location = new Point(xScaleElevatorRightDoor -= 1, yScaleElevatorRightDoor);
            }
            else
            {
                if (doorsOpen)
                {
                    logRequest(this, EventArgs.Empty, 3);
                }
                RemoveTimer();
                doorsOpen = false;
                if (requestedFloor == currentFloor)
                {
                    programActive = false;
                }
            }
        }
        //==================================================================================================
        //Call the elevator to requested floor
        private void MoveElevator(int floorNo)
        {
            if (!doorsOpen)
            {
                int destinationPosition = floorNo == 0 ? elevatorPositionGroundFloor :
                                          floorNo == 1 ? elevatorPositionFirstFloor :
                                          0;
                switch (floorNo)
                {
                    case 0:
                        if (yScaleElevatorBox < destinationPosition)
                        {
                            elevatorBox.Location = new Point(83, yScaleElevatorBox += 2);
                        }
                        else
                        {
                            RemoveTimer();
                            floorReached(this, EventArgs.Empty, floorNo);
                        }
                        break;
                    case 1:
                        if (yScaleElevatorBox > destinationPosition)
                        {
                            elevatorBox.Location = new Point(83, yScaleElevatorBox -= 2);
                        }
                        else
                        {
                            RemoveTimer();
                            floorReached(this, EventArgs.Empty, floorNo);
                        }
                        break;
                }
            }
        }
        //==================================================================================================
        //Reset button colors
        private void ResetButtonColours()
        {
            if (currentFloor == 1)
            {
                firstFloorButton.BackColor = Color.Ivory;
                firstFloorCallButton.BackColor = Color.Ivory;
            }
            else
            {
                groundFloorButton.BackColor = Color.Ivory;
                groundFloorCallButton.BackColor = Color.Ivory;
            }
        }

        //==================================================================================================
        //Ground floor request button inside the elevator
        private void GroundFloorButton_Click(object sender, EventArgs e)
        {
            RequestGroundFloor(1);
        }
        //==================================================================================================
        //Ground floor request button outside the elevator
        private void GroundFloorRequestButton_Click(object sender, EventArgs e)
        {
            RequestGroundFloor(2);
        }
        //==================================================================================================
        //Request to move elevator to ground floor, change button background color
        private void RequestGroundFloor(int buttonId)
        {
            logRequest(this, EventArgs.Empty, 4);
            if (!programActive)
            {
                if (currentFloor == 0)
                {
                    TimerSetting(1, 0);
                    programActive = true;
                }
                else
                {
                    requestedFloor = 0;
                    if (buttonId == 1) { groundFloorButton.BackColor = Color.GreenYellow; }
                    else { groundFloorCallButton.BackColor = Color.GreenYellow; }
                    floorRequest(this, EventArgs.Empty, 0);
                    programActive = true;
                    currentFloor = -1;
                }
            }
        }
        //==================================================================================================
        //First floor request button inside the elevator
        private void FirstFloorButton_Click(object sender, EventArgs e)
        {
            RequestFirstFloor(1);
        }
        //==================================================================================================
        //First floor request button outside the elevator
        private void FirstFloorCallButton_Click(object sender, EventArgs e)
        {
            RequestFirstFloor(2);
        }
        //==================================================================================================
        //Request to move elevator to first floor, change button background color
        private void RequestFirstFloor(int buttonId)
        {
            logRequest(this, EventArgs.Empty, 5);
            if (!programActive)
            {
                programActive = true;
                if (currentFloor == 1)
                {
                    programActive = true;
                    TimerSetting(1, 1);
                }
                else
                {
                    requestedFloor = 1;
                    if (buttonId == 1) { firstFloorButton.BackColor = Color.GreenYellow; }
                    else { firstFloorCallButton.BackColor = Color.GreenYellow; }
                    floorRequest(this, EventArgs.Empty, 1);
                    programActive = true;
                    currentFloor = -1;
                }
            }
        }
        //==================================================================================================
        //Get log button. Creates a worker for data display
        private void GetLogButton_Click(object sender, EventArgs e)
        {
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(Worker_DoWorkFillDataDisplay);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }
        //==================================================================================================
        //Data display worker
        private void Worker_DoWorkFillDataDisplay(object sender, DoWorkEventArgs e)
        {
            logRequest(this, EventArgs.Empty, 6);
            try
            {
                DataTable logTable = dataSet.Tables["ElevatorLogs"];
                int i = 0;
                string[] temp = new string[logTable.Rows.Count];
                string displayString;

                foreach (DataRow row in logTable.Rows)
                {              
                    i++;
                    displayString = (i + "    -    " + row["logDate"].ToString() + "    -    " + row["logText"].ToString());
                    temp[i - 1] = displayString;
                }
                e.Result = temp;
            }
            catch (NullReferenceException ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
            
        }
        //==================================================================================================
        //Worker completed for data display worker
        public void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                logBox.Items.Clear();
                string[] temp = (string[])e.Result;
                logBox.Items.AddRange(temp);
                worker.Dispose();
            }
            catch (ArgumentNullException ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }
        //==================================================================================================
        //Make a background worker to update database and log event
        private void UpdateDatabaseButton_Click(object sender, EventArgs e)
        {
            logRequest(this, EventArgs.Empty, 7);
            logger.LogData();
        }
        //==================================================================================================
        //Call database update periodically (every 30 minutes)
        private void TimedDatabaseUpdate()
        {
            Timer updateTimer = new Timer();
            updateTimer.Tick += new EventHandler(UpdateDatabaseButton_Click);
            updateTimer.Interval = 1800000;
            updateTimer.Enabled = true;
        }
    }
}
