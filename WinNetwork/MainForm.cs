namespace WinNetwork
{
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;

    public partial class MainForm : Form
    {
        Comms comms;

        delegate void OutputWriteLineCallback(string text);
        public MainForm()
        {
            InitializeComponent();
            OutputWriteLine("");
            comms = new Comms();
        }
        private void OutputWriteLine(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBoxStatus.InvokeRequired)
            {
                OutputWriteLineCallback d = new OutputWriteLineCallback(OutputWriteLine);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (text != "")
                {
                    DateTime currentTime = DateTime.Now;
                    text = (currentTime.ToString("hh:mm:ss tt")) + ":   " + text;
                }
                this.textBoxStatus.AppendText(text + Environment.NewLine);
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {}

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (comms.getStatus() == true)
            {
                OutputWriteLine("disconnected from device");
                comms.Close();
                dev1StatusLabel.Hide();
                connectButton.Text = "Connect";
            }
            else
            {
                OutputWriteLine("connecting to device... ");
                if (comms.Open() == true)
                {
                    OutputWriteLine("connection accepted");
                    dev1StatusLabel.Show();
                    connectButton.Text = "D/C";
                    dev1RestartButton.Enabled = true;
                    dev1LoadButton.Enabled = true;
                    dev1SaveButton.Enabled = true;
                }
                else
                {
                    OutputWriteLine("connection refused");
                }
            }
        }

        private void dev1RestartButton_Click(object sender, EventArgs e)
        {
            String s = "sent restart request to device 1";
            if (comms.Write(s) == true)
            {
                OutputWriteLine(s);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dev1StatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}