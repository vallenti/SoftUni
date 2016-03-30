using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Battery
    {
        private int numberOfCells;
        private int capacity;
        private double batteryLife;

        public Material Material { get; set; }
        public int NumberOfCells
        {
            get
            {
                return this.numberOfCells;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Number of cells cannot be negative number");
                }
                this.numberOfCells = value;
            }
        }
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity cannot be negative number");
                }
                this.capacity = value;
            }
        }
        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery life cannot be negative number");
                }
                this.batteryLife = value;
            }
        }

        public Battery(Material material, int numberOfCells, int capacity, double batteryLife)
        {
            this.Material = material;
            this.NumberOfCells = numberOfCells;
            this.Capacity = capacity;
            this.BatteryLife = batteryLife;
        }
    }
    enum Material
    {
        LiIon,
        NiMH
    }
}
