using System;

class CalculateSum
{
    static void Main()
    {
        /*find the sum of sequence 1+1!/x+2!/x^2+3!/x^3.... to N*/
        double factorial = 1;
        double power = 1;
        double sum = 0;
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        for (int k = 0; k <= n; k++)
        {
            if (k>0)
            {
                factorial *= k;
                power *= x;
            }
            sum += (factorial / power);
        }
        Console.WriteLine(sum);
    }
}
