namespace WinNetwork
{
    using System.Net;
    using System.Net.Sockets;

    public partial class MainForm : Form
    {
        Comms comms;

        delegate void OutputWriteLineCallback(string text);
        public MainForm()
        {
            InitializeComponent();
            OutputWriteLine("Welcome to WinNetwork!");
            OutputWriteLine("");
            comms = new Comms();
        }
        private void OutputWrite(string text, bool newline = false)
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
                this.textBoxStatus.AppendText(text);
                if (newline) {
                    this.textBoxStatus.AppendText(Environment.NewLine);
                }
            }
        }

        private void OutputWriteLine(string text) { OutputWrite(text, true); }

        private void MainForm_Load(object sender, EventArgs e) {}

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (comms.getStatus() == true)
            {
                OutputWriteLine("disconnected from device");
                comms.Close();
                dev1StatusLabel.Text = "Disconnected";
                connectButton.Text = "Connect";
            }
            else
            {
                OutputWrite("connecting to device... ");
                if (comms.Open() == true)
                {
                    OutputWriteLine("accepted");
                    dev1StatusLabel.Text = "Connected";
                    connectButton.Text = "Disconnect";
                }
                else
                {
                    OutputWriteLine("refused");
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
    }
}