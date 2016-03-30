using System;

class PiggyBank
{
    static void Main()
    {
        int priceTank = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());
        int moneyNormalDays = (30-partyDays)*2;
        int moneyPartyDays = partyDays * 5;
        if (partyDays > 8)
        {
            Console.WriteLine("never");
            return;
        }
        int moneyPerMonth = moneyNormalDays - moneyPartyDays;
        double totalMonths = (double)(priceTank / moneyPerMonth);
        int result = (int)Math.Ceiling(totalMonths);
        int years = result / 12;
        int months = result % 12;
        Console.WriteLine("{0} years, {1} months",years,months);
    }
}
