using System;

class SpyHard
{
    static void Main(string[] args)
    {
        int key = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();
        message = message.ToLower();
        
        int sum = 0;
        string convertedNumber = "";
        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] >= 'a' && message[i] <= 'z')
            {
                sum += (int)message[i] - 96;
            }
            else
            {
                sum += (int)message[i];
            }
        }
        

        do
        {
            convertedNumber = (sum % key) + convertedNumber;
            sum /= key;
        } while (sum != 0);
        string result = key.ToString() + message.Length + convertedNumber;
        Console.WriteLine(result);
    }
    //public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
    //{
    //    const int BitsInLong = 64;
    //    const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    //    if (radix < 2 || radix > Digits.Length)
    //        throw new ArgumentException("The radix must be >= 2 and <= " +
    //            Digits.Length.ToString());

    //    if (decimalNumber == 0)
    //        return "0";

    //    int index = BitsInLong - 1;
    //    long currentNumber = Math.Abs(decimalNumber);
    //    char[] charArray = new char[BitsInLong];

    //    while (currentNumber != 0)
    //    {
    //        int remainder = (int)(currentNumber % radix);
    //        charArray[index--] = Digits[remainder];
    //        currentNumber = currentNumber / radix;
    //    }

    //    string result = new String(charArray, index + 1, BitsInLong - index - 1);
    //    if (decimalNumber < 0)
    //    {
    //        result = "-" + result;
    //    }

    //    return result;
    //}
}

