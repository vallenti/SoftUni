namespace VehicleParkSystem.Models
{
    using System;

    public class ParkLayout
    {
        private int sectors;
        private int places;

        public ParkLayout(int numberOfSectors, int placesPerSector)
        {
            this.Sectors = numberOfSectors;
            this.Places = placesPerSector;
        }

        public int Sectors
        {
            get
            {
                return this.sectors;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The number of sectors must be positive.");
                }

                this.sectors = value;
            }
        }
        public int Places
        {
            get
            {
                return this.places;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The number of places per sector must be positive.");
                }

                this.places = value;
            }
        }
    }
}
