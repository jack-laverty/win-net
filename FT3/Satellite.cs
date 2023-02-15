using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT3
{
    public class Satellite
    {
        string name;
        double latitude;
        double longitude;
        int height;

        public Satellite(string name, double latitude, double longitude, int height)
        {
            this.name       = name;
            this.latitude   = latitude;
            this.longitude  = longitude;
            this.height     = height;
        }

        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
