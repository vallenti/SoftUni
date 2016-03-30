using System;

class Program
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool hasAnswer = false;
        for (int num1 = 555; num1 <= 999; num1++)
        {
            int num2 = num1 + diff;
            int num3 = num2 + diff;
            if (num2 > 999)
            {
                break;
            }
            int sum1 = CalcSum(num1) + CalcSum(num2) + CalcSum(num3);
            bool checkSum = sum == sum1;
            bool checkDigits = isValidNumber(num1) && isValidNumber(num2) && isValidNumber(num3);
            if (checkSum && checkDigits)
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
    public static bool isValidNumber(int n)
    {
        string num = n.ToString();
        foreach (var digit in num)
        {
            if (digit < '5' || digit > '9')
            {
                return false;
            }
        }
        return true;
    }
    public static int CalcSum(int n){
        string num = n.ToString();
        int sum = 0;
        foreach (var digit in num)
        {
            sum += int.Parse(digit.ToString());
        }
        return sum;
    }
}

