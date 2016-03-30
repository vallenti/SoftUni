using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;
using ConsoleApplication1.Interfaces;
using ConsoleApplication1.Models;
using ConsoleApplication1.Core;
using System.Threading;
using System.Globalization;

namespace ConsoleApplication1
{
    public class PhoneBookApp
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var engine = new Engine();
            engine.Run();
        }
    }
}
