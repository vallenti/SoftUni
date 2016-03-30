using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GalacticGPS
{
    struct Location
    {
        private double latitude;
        private double longitude;

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                if(value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Latitude must be number in range [-90, 90]");
                }
                this.latitude = value;
            }
        }
        public double Longitude
        {
            get
            {
                return this.longitude;
            }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("Longitude must be number in range [-180, 180]");
                }
                this.longitude = value;
            }
        }
        public Planet Planet { get; set; }
        public override string ToString()
        {
            return String.Format("{0},{1} - {2}", Latitude, Longitude, Planet);
        }
    }
}
