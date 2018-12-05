using System;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Data;
using System.ComponentModel;

namespace Elevator
{
    class Logger
    {
        private BackgroundWorker worker;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        private DataSet dataSet;

        private string userName;
        private string passWord;
        private string databaseName;
        private string server;
        private string databasePath;

        //==================================================================================================
        //Constructor for Logger
        public Logger() {
            //MySQL database server information
            userName = "Client";
            passWord = "ClientAccess";
            databaseName = "elevator";
            server = "localhost";
            databasePath = "server=" + server + ";user=" + userName + ";database=" + databaseName + ";password=" + passWord;

            connection = new MySqlConnection(databasePath);
            adapter = new MySqlDataAdapter();
            command = new MySqlCommand();
            builder = new MySqlCommandBuilder(adapter);
            dataSet = new DataSet();
        }
        //==================================================================================================
        //Attempt a database connection
        public void ConnectToDatabase()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }
        //==================================================================================================
        //Log data to database
        public void LogData()
        {
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(Worker_DoWorkLogData);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }
        //==================================================================================================
        //Get data from database
        public DataSet GetData()
        {
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(Worker_DoWorkGetData);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
            return dataSet;
        }
        //Worker synchronizes dataset with the database
        //==================================================================================================
        private void Worker_DoWorkLogData(object sender, DoWorkEventArgs e)
        {
            try
            {
                adapter.Update(dataSet, "elevatorlogs");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }
        //==================================================================================================
        //Worker runs a database query and populates the dataset
        private void Worker_DoWorkGetData(object sender, DoWorkEventArgs e)
        {
            try
            {
                command.CommandText = "SELECT elevatorlogs.logDate, elevatorLogs.logText FROM elevator.elevatorlogs";
                command.Connection = connection;
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "elevatorLogs");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }
        //==================================================================================================
        //Dispose of worker once the task is comleted
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                worker.Dispose();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
