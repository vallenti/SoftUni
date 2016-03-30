using System;

    class FormattingNumbers
    {
        static void Main()
        {
            int a = Int32.MaxValue;
            do {
                a = int.Parse(Console.ReadLine());
            } while (a<0 || a> 500);
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("|{0,-10:X}|{1,10}|{2,10:0.##}|{3,-10:0.###}|",a,Convert.ToString(a, 2).PadLeft(10, '0'),b,c));
        }
    }

