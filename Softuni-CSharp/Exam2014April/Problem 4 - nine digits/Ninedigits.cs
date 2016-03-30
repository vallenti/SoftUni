using System;

class Ninedigits
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool hasAnswer = false;
        for (int num1 = 111; num1 < 778; num1++)
        {
            int num2 = num1+diff;
            int num3 = num2+diff;
            bool allowedNumber = isAllowedNumber(num1) && isAllowedNumber(num2) && isAllowedNumber(num3);
            bool checkDiff = ((num3 - num2) == (num2 - num1)) && ((num2 - num1) == diff);
            bool checkSum = (num1 <= num2) && (num2 <= num3);
            bool checkNum = calculateSum(num1) + calculateSum(num2) + calculateSum(num3) == sum;
            if (allowedNumber && checkDiff && checkSum && checkNum)
            {
                Console.WriteLine("{0}{1}{2}",num1,num2,num3);
                hasAnswer = true;
            }
        }
        if (!hasAnswer)
        {
            Console.WriteLine("No");
        }

    }
    public static bool isAllowedNumber(int num)
    {
        string digits = num.ToString();
        foreach (char digit in digits)
        {
            if (digit < '1' || digit > '7')
            {
                return false;
            }
        }
        return true;
    }
    public static int calculateSum(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        return sum;
    }
}

