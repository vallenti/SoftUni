using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AverageLoadTimeCalculator
{
    static void Main()
    {
        Dictionary<string, List<double>> urlLoadTime = new Dictionary<string, List<double>>();
        string line;
        do
        {
            //read line from console
            line = Console.ReadLine();
            if (line != string.Empty)
            {
                //remove date and time
                line = line.Substring(18);

                //find index of the interval after the url
                int spaceIndex = line.IndexOf(' ');
                
                //get url and time into variables
                string url = line.Substring(0, spaceIndex);
                double loadTime = double.Parse(line.Substring(spaceIndex));

                //add url and time to the dictionary
                if (urlLoadTime.ContainsKey(url))
                {
                    urlLoadTime[url].Add(loadTime);
                }
                else
                {
                     urlLoadTime[url] = new List<double>() { loadTime };
                }
            }
        } while (line != string.Empty);

        //print result
        foreach (var url in urlLoadTime)
        {
            Console.WriteLine("{0} -> {1}",url.Key,url.Value.Average());   
        }
    }
}

