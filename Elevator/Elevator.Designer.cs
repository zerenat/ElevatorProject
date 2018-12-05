
namespace Elevator
{
    partial class Elevator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elevator));
            this.groundFloorButton = new System.Windows.Forms.Button();
            this.firstFloorButton = new System.Windows.Forms.Button();
            this.elevatorLeftDoor = new System.Windows.Forms.PictureBox();
            this.elevatorRightDoor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.animationDisplayPanel = new System.Windows.Forms.Panel();
            this.firstFloorLabel = new System.Windows.Forms.Label();
            this.groundFloorLabel = new System.Windows.Forms.Label();
            this.elevatorBox = new System.Windows.Forms.Panel();
            this.logBox = new System.Windows.Forms.ListBox();
            this.getLogButton = new System.Windows.Forms.Button();
            this.updateDatabaseButton = new System.Windows.Forms.Button();
            this.insideElevatorPanel = new System.Windows.Forms.Panel();
            this.loggerInfoLabel = new System.Windows.Forms.Label();
            this.firstFloorCallPanel = new System.Windows.Forms.Panel();
            this.firstFloorCallButton = new System.Windows.Forms.Button();
            this.firstFloorCallLabel = new System.Windows.Forms.Label();
            this.groundFloorCallPanel = new System.Windows.Forms.Panel();
            this.groundFloorCallButton = new System.Windows.Forms.Button();
            this.groundFloorCallLabel = new System.Windows.Forms.Label();
            this.loggerPanel = new System.Windows.Forms.Panel();
            this.groundFloorPanelLabel = new System.Windows.Forms.Label();
            this.firstFloorPanelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorLeftDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorRightDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.animationDisplayPanel.SuspendLayout();
            this.elevatorBox.SuspendLayout();
            this.insideElevatorPanel.SuspendLayout();
            this.firstFloorCallPanel.SuspendLayout();
            this.groundFloorCallPanel.SuspendLayout();
            this.loggerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groundFloorButton
            // 
            this.groundFloorButton.BackColor = System.Drawing.Color.Ivory;
            this.groundFloorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.groundFloorButton.FlatAppearance.BorderSize = 2;
            this.groundFloorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groundFloorButton.Location = new System.Drawing.Point(400, 166);
            this.groundFloorButton.Name = "groundFloorButton";
            this.groundFloorButton.Size = new System.Drawing.Size(81, 67);
            this.groundFloorButton.TabIndex = 0;
            this.groundFloorButton.Text = "G";
            this.groundFloorButton.UseVisualStyleBackColor = false;
            this.groundFloorButton.Click += new System.EventHandler(this.GroundFloorButton_Click);
            // 
            // firstFloorButton
            // 
            this.firstFloorButton.BackColor = System.Drawing.Color.Ivory;
            this.firstFloorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.firstFloorButton.FlatAppearance.BorderSize = 2;
            this.firstFloorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstFloorButton.Location = new System.Drawing.Point(400, 69);
            this.firstFloorButton.Name = "firstFloorButton";
            this.firstFloorButton.Size = new System.Drawing.Size(81, 67);
            this.firstFloorButton.TabIndex = 1;
            this.firstFloorButton.Text = "1";
            this.firstFloorButton.UseVisualStyleBackColor = false;
            this.firstFloorButton.Click += new System.EventHandler(this.FirstFloorButton_Click);
            // 
            // elevatorLeftDoor
            // 
            this.elevatorLeftDoor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.elevatorLeftDoor.Enabled = false;
            this.elevatorLeftDoor.Image = ((System.Drawing.Image)(resources.GetObject("elevatorLeftDoor.Image")));
            this.elevatorLeftDoor.Location = new System.Drawing.Point(14, -2);
            this.elevatorLeftDoor.Name = "elevatorLeftDoor";
            this.elevatorLeftDoor.Size = new System.Drawing.Size(84, 145);
            this.elevatorLeftDoor.TabIndex = 2;
            this.elevatorLeftDoor.TabStop = false;
            // 
            // elevatorRightDoor
            // 
            this.elevatorRightDoor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.elevatorRightDoor.Image = ((System.Drawing.Image)(resources.GetObject("elevatorRightDoor.Image")));
            this.elevatorRightDoor.Location = new System.Drawing.Point(98, -2);
            this.elevatorRightDoor.Name = "elevatorRightDoor";
            this.elevatorRightDoor.Size = new System.Drawing.Size(88, 145);
            this.elevatorRightDoor.TabIndex = 3;
            this.elevatorRightDoor.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(258, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 358);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // animationDisplayPanel
            // 
            this.animationDisplayPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.animationDisplayPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("animationDisplayPanel.BackgroundImage")));
            this.animationDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animationDisplayPanel.Controls.Add(this.firstFloorLabel);
            this.animationDisplayPanel.Controls.Add(this.groundFloorLabel);
            this.animationDisplayPanel.Controls.Add(this.pictureBox2);
            this.animationDisplayPanel.Controls.Add(this.pictureBox1);
            this.animationDisplayPanel.Controls.Add(this.elevatorBox);
            this.animationDisplayPanel.Location = new System.Drawing.Point(0, 0);
            this.animationDisplayPanel.Name = "animationDisplayPanel";
            this.animationDisplayPanel.Size = new System.Drawing.Size(374, 359);
            this.animationDisplayPanel.TabIndex = 6;
            // 
            // firstFloorLabel
            // 
            this.firstFloorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstFloorLabel.Image = ((System.Drawing.Image)(resources.GetObject("firstFloorLabel.Image")));
            this.firstFloorLabel.Location = new System.Drawing.Point(26, 20);
            this.firstFloorLabel.Name = "firstFloorLabel";
            this.firstFloorLabel.Size = new System.Drawing.Size(35, 31);
            this.firstFloorLabel.TabIndex = 11;
            this.firstFloorLabel.Text = "1";
            this.firstFloorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groundFloorLabel
            // 
            this.groundFloorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groundFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groundFloorLabel.Image = ((System.Drawing.Image)(resources.GetObject("groundFloorLabel.Image")));
            this.groundFloorLabel.Location = new System.Drawing.Point(26, 214);
            this.groundFloorLabel.Name = "groundFloorLabel";
            this.groundFloorLabel.Size = new System.Drawing.Size(38, 33);
            this.groundFloorLabel.TabIndex = 10;
            this.groundFloorLabel.Text = "G";
            // 
            // elevatorBox
            // 
            this.elevatorBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.elevatorBox.Controls.Add(this.elevatorRightDoor);
            this.elevatorBox.Controls.Add(this.elevatorLeftDoor);
            this.elevatorBox.Location = new System.Drawing.Point(83, 214);
            this.elevatorBox.Name = "elevatorBox";
            this.elevatorBox.Size = new System.Drawing.Size(192, 143);
            this.elevatorBox.TabIndex = 6;
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(3, 3);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(508, 160);
            this.logBox.TabIndex = 7;
            // 
            // getLogButton
            // 
            this.getLogButton.Location = new System.Drawing.Point(331, 169);
            this.getLogButton.Name = "getLogButton";
            this.getLogButton.Size = new System.Drawing.Size(180, 30);
            this.getLogButton.TabIndex = 8;
            this.getLogButton.Text = "Get logs";
            this.getLogButton.UseVisualStyleBackColor = true;
            this.getLogButton.Click += new System.EventHandler(this.GetLogButton_Click);
            // 
            // updateDatabaseButton
            // 
            this.updateDatabaseButton.Location = new System.Drawing.Point(331, 205);
            this.updateDatabaseButton.Name = "updateDatabaseButton";
            this.updateDatabaseButton.Size = new System.Drawing.Size(180, 30);
            this.updateDatabaseButton.TabIndex = 9;
            this.updateDatabaseButton.Text = "Update Logs";
            this.updateDatabaseButton.UseVisualStyleBackColor = true;
            this.updateDatabaseButton.Click += new System.EventHandler(this.UpdateDatabaseButton_Click);
            // 
            // insideElevatorPanel
            // 
            this.insideElevatorPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("insideElevatorPanel.BackgroundImage")));
            this.insideElevatorPanel.Controls.Add(this.groundFloorButton);
            this.insideElevatorPanel.Controls.Add(this.firstFloorButton);
            this.insideElevatorPanel.Controls.Add(this.animationDisplayPanel);
            this.insideElevatorPanel.Location = new System.Drawing.Point(12, 22);
            this.insideElevatorPanel.Name = "insideElevatorPanel";
            this.insideElevatorPanel.Size = new System.Drawing.Size(514, 359);
            this.insideElevatorPanel.TabIndex = 10;
            // 
            // loggerInfoLabel
            // 
            this.loggerInfoLabel.Location = new System.Drawing.Point(0, 0);
            this.loggerInfoLabel.Name = "loggerInfoLabel";
            this.loggerInfoLabel.Size = new System.Drawing.Size(100, 23);
            this.loggerInfoLabel.TabIndex = 14;
            // 
            // firstFloorCallPanel
            // 
            this.firstFloorCallPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstFloorCallPanel.BackgroundImage")));
            this.firstFloorCallPanel.Controls.Add(this.firstFloorCallButton);
            this.firstFloorCallPanel.Controls.Add(this.firstFloorCallLabel);
            this.firstFloorCallPanel.Location = new System.Drawing.Point(852, 291);
            this.firstFloorCallPanel.Name = "firstFloorCallPanel";
            this.firstFloorCallPanel.Size = new System.Drawing.Size(104, 175);
            this.firstFloorCallPanel.TabIndex = 12;
            // 
            // firstFloorCallButton
            // 
            this.firstFloorCallButton.BackColor = System.Drawing.Color.Ivory;
            this.firstFloorCallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstFloorCallButton.Location = new System.Drawing.Point(25, 106);
            this.firstFloorCallButton.Name = "firstFloorCallButton";
            this.firstFloorCallButton.Size = new System.Drawing.Size(55, 51);
            this.firstFloorCallButton.TabIndex = 1;
            this.firstFloorCallButton.Text = "CALL";
            this.firstFloorCallButton.UseVisualStyleBackColor = false;
            this.firstFloorCallButton.Click += new System.EventHandler(this.FirstFloorCallButton_Click);
            // 
            // firstFloorCallLabel
            // 
            this.firstFloorCallLabel.BackColor = System.Drawing.Color.Ivory;
            this.firstFloorCallLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstFloorCallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstFloorCallLabel.Location = new System.Drawing.Point(25, 21);
            this.firstFloorCallLabel.Name = "firstFloorCallLabel";
            this.firstFloorCallLabel.Size = new System.Drawing.Size(55, 50);
            this.firstFloorCallLabel.TabIndex = 0;
            this.firstFloorCallLabel.Text = "G";
            this.firstFloorCallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groundFloorCallPanel
            // 
            this.groundFloorCallPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groundFloorCallPanel.BackgroundImage")));
            this.groundFloorCallPanel.Controls.Add(this.groundFloorCallButton);
            this.groundFloorCallPanel.Controls.Add(this.groundFloorCallLabel);
            this.groundFloorCallPanel.Location = new System.Drawing.Point(723, 290);
            this.groundFloorCallPanel.Name = "groundFloorCallPanel";
            this.groundFloorCallPanel.Size = new System.Drawing.Size(104, 176);
            this.groundFloorCallPanel.TabIndex = 13;
            // 
            // groundFloorCallButton
            // 
            this.groundFloorCallButton.BackColor = System.Drawing.Color.Ivory;
            this.groundFloorCallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groundFloorCallButton.Location = new System.Drawing.Point(25, 106);
            this.groundFloorCallButton.Name = "groundFloorCallButton";
            this.groundFloorCallButton.Size = new System.Drawing.Size(55, 51);
            this.groundFloorCallButton.TabIndex = 1;
            this.groundFloorCallButton.Text = "CALL";
            this.groundFloorCallButton.UseVisualStyleBackColor = false;
            this.groundFloorCallButton.Click += new System.EventHandler(this.GroundFloorRequestButton_Click);
            // 
            // groundFloorCallLabel
            // 
            this.groundFloorCallLabel.BackColor = System.Drawing.Color.Ivory;
            this.groundFloorCallLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groundFloorCallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groundFloorCallLabel.Location = new System.Drawing.Point(25, 21);
            this.groundFloorCallLabel.Name = "groundFloorCallLabel";
            this.groundFloorCallLabel.Size = new System.Drawing.Size(55, 49);
            this.groundFloorCallLabel.TabIndex = 0;
            this.groundFloorCallLabel.Text = "G";
            this.groundFloorCallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loggerPanel
            // 
            this.loggerPanel.Controls.Add(this.updateDatabaseButton);
            this.loggerPanel.Controls.Add(this.logBox);
            this.loggerPanel.Controls.Add(this.getLogButton);
            this.loggerPanel.Location = new System.Drawing.Point(553, 22);
            this.loggerPanel.Name = "loggerPanel";
            this.loggerPanel.Size = new System.Drawing.Size(513, 263);
            this.loggerPanel.TabIndex = 15;
            // 
            // groundFloorPanelLabel
            // 
            this.groundFloorPanelLabel.AutoSize = true;
            this.groundFloorPanelLabel.Location = new System.Drawing.Point(723, 473);
            this.groundFloorPanelLabel.Name = "groundFloorPanelLabel";
            this.groundFloorPanelLabel.Size = new System.Drawing.Size(92, 13);
            this.groundFloorPanelLabel.TabIndex = 16;
            this.groundFloorPanelLabel.Text = "ground floor panel";
            // 
            // firstFloorPanelLabel
            // 
            this.firstFloorPanelLabel.AutoSize = true;
            this.firstFloorPanelLabel.Location = new System.Drawing.Point(849, 473);
            this.firstFloorPanelLabel.Name = "firstFloorPanelLabel";
            this.firstFloorPanelLabel.Size = new System.Drawing.Size(75, 13);
            this.firstFloorPanelLabel.TabIndex = 17;
            this.firstFloorPanelLabel.Text = "first floor panel";
            // 
            // Elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 649);
            this.Controls.Add(this.firstFloorPanelLabel);
            this.Controls.Add(this.groundFloorPanelLabel);
            this.Controls.Add(this.loggerPanel);
            this.Controls.Add(this.firstFloorCallPanel);
            this.Controls.Add(this.groundFloorCallPanel);
            this.Controls.Add(this.loggerInfoLabel);
            this.Controls.Add(this.insideElevatorPanel);
            this.Location = new System.Drawing.Point(99, 210);
            this.Name = "Elevator";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.elevatorLeftDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorRightDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.animationDisplayPanel.ResumeLayout(false);
            this.elevatorBox.ResumeLayout(false);
            this.insideElevatorPanel.ResumeLayout(false);
            this.firstFloorCallPanel.ResumeLayout(false);
            this.groundFloorCallPanel.ResumeLayout(false);
            this.loggerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.Button groundFloorButton;
        private System.Windows.Forms.Button firstFloorButton;
        private System.Windows.Forms.PictureBox elevatorLeftDoor;
        private System.Windows.Forms.PictureBox elevatorRightDoor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel animationDisplayPanel;
        private System.Windows.Forms.Button getLogButton;
        private System.Windows.Forms.Button updateDatabaseButton;
        private System.Windows.Forms.Panel elevatorBox;
        private System.Windows.Forms.Label groundFloorLabel;
        private System.Windows.Forms.Label firstFloorLabel;
        private System.Windows.Forms.Panel insideElevatorPanel;
        private System.Windows.Forms.Label loggerInfoLabel;
        private System.Windows.Forms.Panel firstFloorCallPanel;
        private System.Windows.Forms.Button firstFloorCallButton;
        private System.Windows.Forms.Label firstFloorCallLabel;
        private System.Windows.Forms.Panel groundFloorCallPanel;
        private System.Windows.Forms.Button groundFloorCallButton;
        private System.Windows.Forms.Label groundFloorCallLabel;
        private System.Windows.Forms.Panel loggerPanel;
        private System.Windows.Forms.Label groundFloorPanelLabel;
        private System.Windows.Forms.Label firstFloorPanelLabel;
    }
}

