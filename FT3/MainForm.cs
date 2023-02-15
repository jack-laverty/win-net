using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RJCP.IO.Ports;
using System.Timers;
using FT3;

namespace FT3
{
    public partial class MainForm : Form
    {
        //private SerialPortStream port = new SerialPortStream(FT3.Properties.Settings.Default.SerialPortName);

        //string serialPort = FT3.Properties.Settings.Default.SerialPortName;
        //int serialSpeed = FT3.Properties.Settings.Default.SerialPortSpeed;

        public static DatalogWriter dlw;
        bool dataLoggingEnabled = false;

        private static System.Timers.Timer dataLoggingTimer;
        private static System.Timers.Timer usbTimer;

        delegate void SetTextCallback(string text);
        delegate void SetValCallback(int val, int index);

        byte[] usb_data = new byte[32];

        public MainForm()
        {
            InitializeComponent();
            //port.DataReceived += port_OnDataReceived;
            SetTimer();
            SetUSBTimer();


            SetText("Welcome to FMS Tool 3.0");
            SetText("");

            //buttonConnect.BackColor = ModernLightGray;
            //buttonSettings.BackColor = ModernLightGray;
            //buttonStartStopLog.BackColor = ModernLightGray;
            //buttonStartTracking.BackColor = ModernLightGray;

            //labelAzimuth.ForeColor = Color.White;
            //labelElevation.ForeColor = Color.White;
            //labelTrackingOutput.ForeColor = Color.White;
            //labelTargetCoords.ForeColor = Color.White;
            //labelTargetLatitude.ForeColor = Color.White;
            //labelSatelliteLongitude.ForeColor = Color.White;
            //labelGPSLatitude.ForeColor = Color.White;
            //labelGPSLongitude.ForeColor = Color.White;

            //textBoxAntennaLatitude.BackColor = ModernDarkGray;
            //textBoxAntennaLongitude.BackColor = ModernDarkGray;
            //textBoxAzimuthVal.BackColor = ModernDarkGray;
            //textBoxElevationVal.BackColor = ModernDarkGray;
            //textBoxLongitude.BackColor = ModernDarkGray;
            //textBoxTargetLatitudeVal.BackColor = ModernDarkGray;

            //comboBoxSatelliteSelect.BackColor = ModernDarkGray;
            //comboBoxSatelliteSelect.ForeColor = Color.White;
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBoxStatus.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxStatus.AppendText(text);
                this.textBoxStatus.AppendText(Environment.NewLine);
            }
        }

        private void SetVal(int val, int index)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            //if(index == 0)
            //{
            //    if (this.textBoxAzimuthVal.InvokeRequired)
            //    {
            //        SetValCallback d = new SetValCallback(SetVal);
            //        this.Invoke(d, new object[] { val, index });
            //    }
            //    else
            //    {
            //        double temp = val;
            //        temp = temp / 100000;
            //        this.textBoxAzimuthVal.Text = Convert.ToString(temp);
            //    }
            //}
            //else if (index == 1)
            //{
            //    if (this.textBoxElevationVal.InvokeRequired)
            //    {
            //        SetValCallback d = new SetValCallback(SetVal);
            //        this.Invoke(d, new object[] { val, index });
            //    }
            //    else
            //    {
            //        double temp = val;
            //        temp = temp / 100000;
            //        this.textBoxElevationVal.Text = Convert.ToString(temp);
            //    }
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void port_OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Show all the incoming data in the port's buffer
            int azimuth;
            int elevation;
            int ant_lat;
            int ant_long;

            try
            {
                SetText("Received USB packet from STM32");
            }
            catch { }

            azimuth = usb_data[0]
                    | (usb_data[1] << 8)
                    | (usb_data[2] << 16)
                    | (usb_data[3] << 24);

            SetVal(azimuth, 0);

            elevation = usb_data[4]
                    | (usb_data[5] << 8)
                    | (usb_data[6] << 16)
                    | (usb_data[7] << 24);

            SetVal(elevation, 1);

            ant_lat = usb_data[8]
                    | (usb_data[9] << 8)
                    | (usb_data[10] << 16)
                    | (usb_data[11] << 24);

            SetVal(ant_lat, 2);

            ant_long = usb_data[12]
                    | (usb_data[13] << 8)
                    | (usb_data[14] << 16)
                    | (usb_data[15] << 24);

            SetVal(ant_long, 3);
        }

        private void clear_all_channels()
        {
            SetVal(0, 0);
            SetVal(0, 1);
            SetVal(0, 2);
            SetVal(0, 3);
        }

        private void buttonSend_Click_1(object sender, EventArgs e)
        {
            //string str = "Hello World!";
            //port.Write(str);

            //USBComms.update_latitude(sats[comboBoxSatelliteSelect.SelectedIndex].Latitude);
            //USBComms.update_longitude(sats[comboBoxSatelliteSelect.SelectedIndex].Longitude);
        }

        private void labelCommsStatus_Click(object sender, EventArgs e)
        {

        }

        private void labelCommsStatusVal_Click(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click_1(object sender, EventArgs e)
        {

            //if (serialPort.Trim().Length == 0)
            //{
            //    MessageBox.Show("Please select a port", Text,
            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //if (serialSpeed == 0)
            //{
            //    MessageBox.Show("Please select a port connect speed", Text,
            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //if (port.IsOpen == false)
            //{
            //    port.PortName = serialPort;
            //    try
            //    {
            //        port.OpenDirect();
            //        buttonConnect.BackColor = Color.MediumSpringGreen;
            //        usbTimer.Enabled = true;
            //    }
            //    catch (Exception e_var)
            //    {
            //        MessageBox.Show("Failed to open port", Text,
            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //}
            //else if (port.IsOpen)
            //{
            //    port.Close();
            //    buttonConnect.BackColor = ModernLightGray;
            //    clear_all_channels();
            //    usbTimer.Enabled = false;
            //}
        }

        private void buttonStartStopLog_Click(object sender, EventArgs e)
        {
            if(dataLoggingEnabled == false)
            {
                dataLoggingEnabled = true;
                //buttonStartStopLog.BackColor = Color.MediumSpringGreen;
                dataLoggingTimer.Enabled = true;
                dlw = new DatalogWriter();
            }
            else
            {
                dataLoggingEnabled = false;
                //buttonStartStopLog.BackColor = ModernLightGray;
                dataLoggingTimer.Enabled = false;
                dlw.CloseFileStream();
            }
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            dataLoggingTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            dataLoggingTimer.Elapsed += OnTimedEvent;
            dataLoggingTimer.AutoReset = true;
            dataLoggingTimer.Enabled = false;
        }

        public static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Datalogging event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
            Console.WriteLine("Azimuth Angle:       0.0", e.SignalTime);
            Console.WriteLine("Elevation Angle:     0.0", e.SignalTime);

            dlw.WriteData(e.SignalTime);
        }

        private void SetUSBTimer()
        {
            // Create a timer with a two second interval.
            usbTimer = new System.Timers.Timer(100);
            // Hook up the Elapsed event for the timer. 
            usbTimer.Elapsed += USBSend;
            usbTimer.AutoReset = true;
            usbTimer.Enabled = false;
        }

        public void USBSend(Object source, ElapsedEventArgs e)
        {
            SetText(string.Format("Sent USB packet to STM32 at {0:HH:mm:ss.fff}", e.SignalTime));
        }

        private void textBoxTargetLatitudeVal_TextChanged(object sender, EventArgs e)
        {
            //USBComms.update_latitude(sats[comboBoxSatelliteSelect.SelectedIndex].Latitude);
        }

        private void textBoxLongitude_TextChanged(object sender, EventArgs e)
        {
            //USBComms.update_longitude(sats[comboBoxSatelliteSelect.SelectedIndex].Longitude);
        }

        private void buttonStartTracking_Click(object sender, EventArgs e)
        {
            //if(trackingEnabled == false)
            //{
            //    trackingEnabled = true;
            //    buttonStartTracking.BackColor = Color.MediumSpringGreen;
            //}
            //else
            //{
            //    trackingEnabled = false;
            //    buttonStartTracking.BackColor = ModernLightGray;
            //}
            
        }

        private void comboBoxSatelliteSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (sats[comboBoxSatelliteSelect.SelectedIndex].Name == "Custom")
            //{
            //    textBoxTargetLatitudeVal.Enabled = true;
            //    textBoxLongitude.Enabled = true;
            //}
            //else
            //{
            //    textBoxTargetLatitudeVal.Enabled = false;
            //    textBoxLongitude.Enabled = false;
            //}

            //string s = string.Format("{0:N2}", sats[comboBoxSatelliteSelect.SelectedIndex].Longitude);
            //textBoxLongitude.Text = s;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SetText("Restart CMD: Device 1");
        }
    }
}
