using System;

class NumbersToText
{
    static void Main()
    {
        Console.Write("Enter number between 0 and 999: ");
        short num = short.Parse(Console.ReadLine());
        bool flag = true;
        if (num < 0 || num > 999)
        {
            Console.WriteLine("Please input correct value (0-999)!");
        }
        else
        {
            int a = num / 100;           //find hundreds
            int b = (num / 10) % 10;     //find tens
            int c = (num % 100) % 10;    //find ones

            switch (a)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
                case 0: break;
            }
            switch (b)
            {
                case 1:
                    if (a > 0)
                    {
                        Console.Write("and ");
                    }
                        switch (c)
                        {
                            case 0: Console.Write("ten"); flag = false; break;
                            case 1: Console.Write("eleven"); flag=false; break;
                            case 2: Console.Write("twelve"); flag=false; break;
                            case 3: Console.Write("thirteen"); flag=false; break;
                            case 4: Console.Write("fourteen"); flag=false; break;
                            case 5: Console.Write("fifteen"); flag=false; break;
                            case 6: Console.Write("sixteen"); flag=false; break;
                            case 7: Console.Write("seventeen"); flag=false; break;
                            case 8: Console.Write("eighteen"); flag=false; break;
                            case 9: Console.Write("nineteen"); flag=false; break;
                        }
                  break;
                case 2: Console.Write("twenty "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("forty "); break;
                case 5: Console.Write("fifty "); break;
                case 6: Console.Write("sixty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninety "); break;
                case 0:
                    if(a>0 && c>0){
                        Console.Write("and ");
                    }
                    break;
            }
            //check for numbers in format 000, 00x, x0x, xxx
            if ((a == 0 && b == 0 && c == 0) || (a == 0 && b > 0 && c > 0) || (a == 0 && b == 0 && c > 0) || (a > 0 && b == 0 && c > 0) || (a > 0 && b > 0 && c > 0))
            {
                switch (c)
                {
                    case 1: Console.Write("one"); break;
                    case 2: Console.Write("two"); break;
                    case 3: Console.Write("three"); break;
                    case 4: Console.Write("four"); break;
                    case 5: Console.Write("five"); break;
                    case 6: Console.Write("six"); break;
                    case 7: Console.Write("seven"); break;
                    case 8: Console.Write("eight"); break;
                    case 9: Console.Write("nine"); break;
                    case 0: Console.Write("zero"); break;
                }
            }
            Console.WriteLine();

        }
    }
}
