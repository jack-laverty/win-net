using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT3
{
    public static class USBComms
    {
        public static byte[] out_buffer = new byte[16];

        public static void update_latitude(double latitude)
        {
            int new_lat = Convert.ToInt32(latitude * 100);
            out_buffer[3] = (byte)(new_lat >> 24);
            out_buffer[2] = (byte)(new_lat >> 16);
            out_buffer[1] = (byte)(new_lat >> 8);
            out_buffer[0] = (byte)(new_lat);
        }

        public static void update_longitude(double longitude)
        {
            int new_long = Convert.ToInt32(longitude * 100);
            out_buffer[7] = (byte)(new_long >> 24);
            out_buffer[6] = (byte)(new_long >> 16);
            out_buffer[5] = (byte)(new_long >> 8);
            out_buffer[4] = (byte)(new_long);
        }
    }
}
