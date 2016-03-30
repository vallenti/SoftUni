using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InterestCalculator
{
    public delegate decimal CalculateInterest(decimal sum, decimal interest, int years);

    class InterestCalculator
    {
        private static readonly int N = 12;
        public InterestCalculator(decimal balance, decimal interest, int years, CalculateInterest calcInterest)
        {
            Balance = balance;
            Interest = interest;
            Years = years;
            CalculatedInterest = calcInterest(balance,interest,years);
        }
        public decimal Balance { get; set; }
        public decimal Interest { get; set; }
        public int Years { get; set; }
        public decimal CalculatedInterest { get; set; }
    }
}
