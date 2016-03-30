using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Manufacturer cannot be empty");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Processor cannot be empty");
                }
                this.processor = value;
            }
        }
        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("RAM cannot be empty");
                }
                this.ram = value;
            }
        }
        public string GraphicCard
        {
            get
            {
                return this.graphicCard;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Graphic card cannot be empty");
                }
                this.graphicCard = value;
            }
        }
        public string HDD
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("HDD cannot be empty");
                }
                this.hdd = value;
            }
        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Screen cannot be empty");
                }
                this.screen = value;
            }
        }
        public Battery Battery { get; set; }
        public double BatteryLife {
            get
            {
                return this.Battery.BatteryLife;
            }
        }
        public decimal Price {
            get
            {
                return this.price;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Price cannot be a negative number");
                }
                this.price = value;
            }
        }

        public Laptop(string model, decimal price) 
            : this(model, null, null, null, null, null, null, null, price)
        {

        }

        public Laptop(string model, string manufacturer, string processor, string ram, string graphicCard,
            string hdd, string screen, Battery battery, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicCard = graphicCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.Price = price;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} lv.",Model, Price);
        }
    }
}
