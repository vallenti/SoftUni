using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InterestCalculator
{
    
    class Program
    {
        static void Main(string[] args)
        {
            CalculateInterest simpleInterestDelegate = new CalculateInterest(GetSimpleInterest);
            CalculateInterest compoundInterestDelegate = new CalculateInterest(GetCompoundInterest);

            InterestCalculator simpleCalc = new InterestCalculator(2500, 0.072m, 15, simpleInterestDelegate);
            InterestCalculator compoundCalc = new InterestCalculator(500, 0.056m, 10, compoundInterestDelegate);

            Console.WriteLine(simpleCalc.CalculatedInterest);
            Console.WriteLine(compoundCalc.CalculatedInterest);
        }

        static decimal GetSimpleInterest(decimal balance, decimal interest, int years)
        {
            return Math.Round((balance * (1 + interest * years)),4);
        }
        static decimal GetCompoundInterest(decimal balance, decimal interest, int years)
        {
            decimal result = balance * (decimal)Math.Pow((double)(1 + (interest/12)), 12 * years);
            return Math.Round(result, 4);
        }
    }
}
