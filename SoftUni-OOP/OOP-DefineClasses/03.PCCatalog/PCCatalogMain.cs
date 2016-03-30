using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    class PCCatalogMain
    {
        static void Main(string[] args)
        {
            Component cpu1 = new Component("CPU1", 400);
            Component ram1 = new Component("RAM1", 200);
            Component gpu1 = new Component("GPU1", 500);
            Component hdd1 = new Component("HDD1", 100);
            Component mb1 = new Component("MB1", 200);
            Computer pc1 = new Computer("PC1", 100,mb1, null, ram1, gpu1, hdd1);
            Console.WriteLine(pc1);
        }
    }
}
