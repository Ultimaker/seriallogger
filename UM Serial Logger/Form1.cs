using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace UM_Serial_Logger
{
    /* let me introduce: A quick and dirty serial logger :)
     * it works for its purpose, so don't try anything else with it
     * functions were added overtime so intentionally it was a lot smaller
     * if this application would've been rewritten it would & should have seperation of concerns...
     */
    
    public partial class Form1 : Form
    {
        private SerialPort mySerialPort;
        private string COM = "";
        private int BAUD = 9600;
        private string[] ports;
        private string logpath;
        private string fileName;
        private bool filecreated = false;
        private bool fileclose = false;
        private string textToAdd = "";
        private int logamount = 0;
        private bool logging = false;
        private int timer = 0;
        private string logID = "";
        private int timerstop = 0;
        

        public Form1()
        {
            InitializeComponent();
            SecondsTimer.Interval = 1000;
            KeyPreview = true;  //is needed for keydown event
            cbTimer.SelectedIndex = 2;

        }

        //COM PORT combobox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            COM = Convert.ToString(cbCom.SelectedItem);
        }


        #region unused events
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        #endregion


        private void btnStart_Click(object sender, EventArgs e)
        {
            fileName = tbFileName.Text;

            //configure all the serial settings and getting preferences
            mySerialPort = new SerialPort(COM);
            mySerialPort.BaudRate = BAUD;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;

            logID = tbLogID.Text;

            //binding the event
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            //opening the serialport and turn logging on
            mySerialPort.Open();
            lblMessage.Text = "Log Started";
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            logging = true;
            fileclose = false;
            
            SecondsTimer.Start();

            //disableing preferences for reasons: spacebar is used to start/stop logging, otherwise you would type in the boxes
            btnSearchCom.Enabled = false;
            cbCom.Enabled = false;
            cbBaudRate.Enabled = false;
            btnLocation.Enabled = false;
            tbFileName.Enabled = false;
            tbLogID.Enabled = false;
            cbTimer.Enabled = false;

        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            //closing the serialport but keeping the preferences!
            mySerialPort.Close();
            textToAdd = "--End-of-Log--";
            fileclose = true;
            txtlog();
            filecreated = false;
            lblMessage.Text = "Log Stopped";
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            logging = false;

            SecondsTimer.Stop();
            timer = 0;
            lblTimer.Text = Convert.ToString(timer);

            //enabling preferences
            btnSearchCom.Enabled = true;
            cbCom.Enabled = true;
            cbBaudRate.Enabled = true;
            btnLocation.Enabled = true;
            tbFileName.Enabled = true;
            tbLogID.Enabled = true;
            cbTimer.Enabled = true;
        }


        private void btnSearchCom_Click(object sender, EventArgs e)
        {
            //Get a list of serial port names. 
            ports = SerialPort.GetPortNames();

            //Display each port name to dropdown menu 
            foreach (string port in ports)
            {
                cbCom.Items.Add(port);
            }
            if (ports.Length == 1)
            {
                cbCom.SelectedIndex = 0;
            }
        }

        //recieve serial eventhandler
        private void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            textToAdd = indata;
            logamount++;
            txtlog();
        }

        private void cbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            BAUD = Convert.ToInt32(cbBaudRate.SelectedItem);
        }

        //The logmethod
        private void txtlog()
        {
            if (filecreated == false) //only used if log is started to indicate beginning of the log and creating the file
            {
                textToAdd = "--ID: " + logID + " --Begin-of-Log--";
                filecreated = true;
                fileName = logpath + "\\" + fileName + ".txt";
            }
            using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write)) //Appending filestream, so if file already exists it appends and doesnt overwrite
            using (StreamWriter sw = new StreamWriter(fs))
            {
                if (fileclose == true)
                {
                    sw.WriteLine(textToAdd);
                    sw.Close();
                    fs.Close();
                }
                else if (fileclose == false)
                {
                    sw.Write(textToAdd);
                }
            }
        }

        //getting log location preference via folderbrowserdialog
        private void btnLocation_Click(object sender, EventArgs e)
        {
            
            Stream myStream = null;
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (myStream)
                    {
                        logpath = folderBrowserDialog1.SelectedPath;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read path from disk. Original error: " + ex.Message);
                }
            }
            tbLogLocation.Text = logpath;
        }

        //keydown event on spacebar (To start & stop logging without using mouse)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space)
            {
                if (logging)
                {
                    btnStop_Click(sender, e);
                }
                else
                {
                    btnStart_Click(sender, e);
                }
            }
        }

        #region unused events
        private void tbFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLogLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //timer tick for logtimer
        private void SecondsTimer_Tick(object sender, EventArgs e)
        {
            if (timerstop == timer)
            {
                btnStop_Click(sender, e);
            }
            else
            {
                timer++;
                lblTimer.Text = Convert.ToString(timer);
            }

            if (timer == 1)
            {
                lblMessage.Text = "Log Begin= --ID:" + logID + "--Begin-of-Log--";
            }
            if (timer == 4)
            {
                lblMessage.Text = "Log in progress";
            }

        }

        private void cbTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            timerstop = Convert.ToInt32(cbTimer.SelectedItem);
        }
    }
}
