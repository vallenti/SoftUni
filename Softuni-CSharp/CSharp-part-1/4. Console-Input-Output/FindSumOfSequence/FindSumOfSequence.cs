using System;

class FindSumOfSequence
{
    static void Main()
    {
        double sum = 1;
        double oldSum=0;
        double sumDifference=1;
        for (float i = 2;sumDifference>0.001 ;i++ )
        {
            oldSum=sum;  
            if (i % 2 == 0)
            {
                sum += (1 / i);
            }
            else
            {
                sum -= (1 / i);
            }
            sumDifference = Math.Abs(sum - oldSum);
        }
        Console.WriteLine("{0:0.001}",sum);
    }
}

