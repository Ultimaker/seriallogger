namespace UM_Serial_Logger
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnSearchCom = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tbLogLocation = new System.Windows.Forms.TextBox();
            this.btnLocation = new System.Windows.Forms.Button();
            this.SecondsTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.cbTimer = new System.Windows.Forms.ComboBox();
            this.tbLogID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchCom
            // 
            this.btnSearchCom.Location = new System.Drawing.Point(12, 12);
            this.btnSearchCom.Name = "btnSearchCom";
            this.btnSearchCom.Size = new System.Drawing.Size(87, 23);
            this.btnSearchCom.TabIndex = 0;
            this.btnSearchCom.Text = "SearchCOM";
            this.btnSearchCom.UseVisualStyleBackColor = true;
            this.btnSearchCom.Click += new System.EventHandler(this.btnSearchCom_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(10, 145);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Log";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(167, 145);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(76, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop Log";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cbCom
            // 
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(105, 14);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(138, 21);
            this.cbCom.TabIndex = 4;
            this.cbCom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Baud Rate:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400"});
            this.cbBaudRate.Location = new System.Drawing.Point(105, 42);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(138, 21);
            this.cbBaudRate.TabIndex = 10;
            this.cbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbBaudRate_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filename";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(105, 95);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(116, 20);
            this.tbFileName.TabIndex = 12;
            this.tbFileName.TextChanged += new System.EventHandler(this.tbFileName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = ".txt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Messages:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(62, 171);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(16, 13);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.Text = "...";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // tbLogLocation
            // 
            this.tbLogLocation.Enabled = false;
            this.tbLogLocation.Location = new System.Drawing.Point(105, 70);
            this.tbLogLocation.Name = "tbLogLocation";
            this.tbLogLocation.Size = new System.Drawing.Size(138, 20);
            this.tbLogLocation.TabIndex = 7;
            this.tbLogLocation.TextChanged += new System.EventHandler(this.tbLogLocation_TextChanged);
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(16, 68);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(83, 23);
            this.btnLocation.TabIndex = 16;
            this.btnLocation.Text = "Log Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // SecondsTimer
            // 
            this.SecondsTimer.Tick += new System.EventHandler(this.SecondsTimer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(145, 150);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(14, 13);
            this.lblTimer.TabIndex = 17;
            this.lblTimer.Text = "0";
            // 
            // cbTimer
            // 
            this.cbTimer.FormattingEnabled = true;
            this.cbTimer.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "999999999"});
            this.cbTimer.Location = new System.Drawing.Point(94, 147);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(45, 21);
            this.cbTimer.TabIndex = 18;
            this.cbTimer.SelectedIndexChanged += new System.EventHandler(this.cbTimer_SelectedIndexChanged);
            // 
            // tbLogID
            // 
            this.tbLogID.Location = new System.Drawing.Point(105, 119);
            this.tbLogID.Name = "tbLogID";
            this.tbLogID.Size = new System.Drawing.Size(138, 20);
            this.tbLogID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "LogID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 196);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLogID);
            this.Controls.Add(this.cbTimer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.tbLogLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCom);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSearchCom);
            this.Name = "Form1";
            this.Text = "UM Serial Logger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchCom;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox tbLogLocation;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Timer SecondsTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ComboBox cbTimer;
        private System.Windows.Forms.TextBox tbLogID;
        private System.Windows.Forms.Label label2;
    }
}

