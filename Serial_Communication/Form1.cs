using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  // Serial Port Handling

namespace Serial_Communication
{
    public partial class Form1 : Form
    {

        private SerialPort SerPort;     // Serial Port
        private string RecievedData;    //Recieved data from serial port
        public Form1()
        {
            InitializeComponent();
            FetchAvailablePorts();
        }

        void FetchAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();  // We getthe availabe COM ports
            AvailablePortsBox.Items.AddRange(ports);
        }

        private void ConnectToPort_Click(object sender, EventArgs e)
        {
            SerPort = new SerialPort();

            //SerPort.BaudRate = 250000;
            SerPort.BaudRate = 9600;
            SerPort.PortName = AvailablePortsBox.Text;
            SerPort.Parity = Parity.None;
            SerPort.StopBits = StopBits.One;
            SerPort.ReadBufferSize = 200000000;
            SerPort.DataReceived += SerPort_DataRecieved;

            try
            {
                SerPort.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR.....!");
            }

        }

        private void SerPort_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            RecievedData = SerPort.ReadLine();      // Read line form serial port
            this.Invoke(new Action(ProcessingData));
        }

        private void ProcessingData()
        {
            
            RecievedDataBox.Text += RecievedData.ToString() + Environment.NewLine;
            RecievedDataBox.SelectionStart = RecievedDataBox.Text.Length;
            RecievedDataBox.ScrollToCaret();
        }

        private void SendSerialButton_Click(object sender, EventArgs e)
        {
            SerPort.WriteLine(SenderTextBox.Text.ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SerPort.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR.....!");
            }
        }
    }
}
