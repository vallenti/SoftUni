using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    class Computer
    {
        private string name;
        private Component cpu;
        private Component motherboard;
        private Component ram;
        private Component graphicCard;
        private Component hdd;
        private decimal price;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                this.name = value;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                this.price = value;
            }
        }
        public Component Cpu { get { return this.cpu; } set { this.cpu = value; } }
        public Component Motherboard { get { return this.motherboard; } set { this.motherboard = value; } }
        public Component Ram { get { return this.ram; } set { this.ram = value; } }
        public Component GraphicCard { get { return this.graphicCard; } set { this.graphicCard = value; } }
        public Component Hdd { get { return this.hdd; } set { this.hdd = value; } }
        public decimal TotalPrice
        {
            get
            {
                decimal cpuPrice = Cpu == null ? 0 : Cpu.Price;
                decimal mbPrice = Motherboard == null ? 0 : Motherboard.Price;
                decimal ramPrice = Ram == null ? 0 : Ram.Price;
                decimal gpuPrice = GraphicCard == null ? 0 : GraphicCard.Price;
                decimal hddPrice = Hdd == null ? 0 : Hdd.Price;
                return this.Price + cpuPrice + mbPrice + ramPrice + gpuPrice + hdd.Price;
            }

        }

        public Computer(string name, decimal price)
            : this(name, price, null, null, null, null, null)
        {
        }

        public Computer(string name, decimal price, Component cpu)
            : this(name, price, cpu, null, null, null, null)
        {
        }

        public Computer(string name, decimal price, Component mb,Component cpu, Component ram, Component graphicCard, Component hdd)
        {
            this.Name = name;
            this.Price = price;
            this.Motherboard = mb;
            this.Cpu = cpu;
            this.Ram = ram;
            this.GraphicCard = graphicCard;
            this.Hdd = hdd;
        }

        public override string ToString()
        {
            //TODO impement it
            string cpuName = Cpu == null ? "[no info]" : Cpu.Name;
            string cpuPrice = Cpu == null ? "[no info]" : Cpu.Price.ToString();
            string ramName = Ram == null ? "[no info]" : Ram.Name;
            string ramPrice = Cpu == null ? "[no info]" : Ram.Price.ToString();
            string gpuName = GraphicCard == null ? "[no info]" : GraphicCard.Name;
            string gpuPrice = GraphicCard == null ? "[no info]" : GraphicCard.Price.ToString();
            string hddName = Hdd == null ? "[no info]" : Hdd.Name;
            string hddPrice = Hdd == null ? "[no info]" : Hdd.Price.ToString();

            return String.Format("Computer name: {0} | Price: {1} | Total price: {2}\nCPU: {3} - {4} lv.\nRAM: {5} - {6} lv.\nGraphic Card: {7} - {8} lv.\nHDD: {9} - {10} lv.",
                this.Name,
                this.Price,
                this.TotalPrice,
                cpuName,
                cpuPrice,
                ramName,
                ramPrice,
                gpuName,
                gpuPrice,
                hddName,
                hddPrice
                );
        }
    }
}
