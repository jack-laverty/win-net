namespace WinNetwork
{
    using System.Net;
    using System.Net.Sockets;

    public partial class MainForm : Form
    {
        delegate void SetTextCallback(string text);
        public MainForm()
        {
            InitializeComponent();
            SetText("Welcome WinNetwork!");
            SetText("");
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

        private void MainForm_Load(object sender, EventArgs e) {}

        private void button3_Click(object sender, EventArgs e)
        {
            SetText("opening a TCP socket...");

            String server = "localhost";
            String message = "Hi from FT3!";

            try
            {
                // Note, for this client to work you need to have a TcpServer
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = 27015;

                // Create a TcpClient.
                // Prefer a using declaration to ensure the instance is Disposed later.
                using TcpClient client = new TcpClient(server, port);

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer.
                stream.Write(data, 0, data.Length);

                Console.WriteLine("Sent: {0}", message);

                // Receive the server response.

                // Buffer to store the response bytes.
                data = new Byte[256];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", responseData);

                // Explicit close is not necessary since TcpClient.Dispose() will be
                // called automatically.
                // stream.Close();
                // client.Close();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("ArgumentNullException: {0}", ex);
                SetText("failed to open socket: null arg");
            }
            catch (SocketException ex)
            {
                Console.WriteLine("SocketException: {0}", ex);
                SetText("failed to open socket: socket exception");
            }
            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
        }
    }
}