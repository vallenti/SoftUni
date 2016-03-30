using System;

class FourDigitNumber
{
    static void Main()
    {
        int num = 2011;
        int d = num % 10;
        num /= 10;
        int c = num % 10;
        num /= 10;
        int b = num % 10;
        num /= 10;
        int a = num;
        if (a == 0)
        {
            Console.WriteLine("Number cannot start with 0;");
            return;
        }
        //calculate sum
        Console.WriteLine(a+b+c+d);
        
        //print reverse number
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);

        //put last digit on first position
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);

        //swap second and third number
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);

    }
}

