using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GalacticGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Location home = new Location(18.037986, 28.870097, Planet.Earth);
                Console.WriteLine(home);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
