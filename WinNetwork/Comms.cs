using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WinNetwork
{
    internal class Comms
    {
        TcpClient socket;
        NetworkStream stream;

        public bool Open()
        {
            bool result = false;
            try
            {
                socket = new TcpClient("localhost", 27015);
                stream = socket.GetStream();
                result = true;
            }
            catch (ArgumentNullException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            catch (SocketException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return result;
        }

        public void Close()
        {
            stream.Close();
            socket.Close();
        }

        public bool Write(String message)
        {
            bool result = true;
            if (stream != null)
            {
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                try
                {
                    stream.Write(data, 0, data.Length);
                }
                catch (Exception ex)
                {
                    result = false;
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }
            else
            {
                result = false;
                System.Diagnostics.Debug.WriteLine("Socket stream is null");
            }
            return result;
        }

        public String Read()
        {
            String result = String.Empty;
            if (stream != null)
            {
                Byte[] data = new Byte[256];
                Int32 bytes = stream.Read(data, 0, data.Length);
                result = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Socket stream is null");
            }
            return result;
        }

        public bool getStatus()
        {
            if (socket == null)
                return false;

            try
            {
                var x = socket.GetStream();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return false;
            }
            return true;
        }
    }
}
