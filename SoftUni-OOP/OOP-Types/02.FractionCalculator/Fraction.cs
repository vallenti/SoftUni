using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FractionCalculator
{
    struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                this.numerator = value;
            }
        }
        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if(value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0");
                }
                this.denominator = value;
            }
        }

        public Fraction Simplify()
        {
            long gcd = GCD();
            return new Fraction(Numerator / gcd, Denominator / gcd);
        }
        public long GCD()
        {
            long a = Numerator;
            long b = Denominator;
            while (b != 0)
            {
                long t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public Fraction Reciprocal()
        {
            return new Fraction(Denominator, Numerator);
        }
        private Fraction InTermsOf(Fraction other)
        {
            return Denominator == other.Denominator ? this :
                new Fraction(Numerator * other.Denominator, Denominator * other.Denominator);
        }
        public static Fraction operator +(Fraction left, Fraction right)
        {
            var left2 = left.InTermsOf(right);
            var right2 = right.InTermsOf(left);

            return new Fraction(left2.Numerator + right2.Numerator, left2.Denominator);
        }

        public static Fraction operator -(Fraction left, Fraction right)
        {
            var left2 = left.InTermsOf(right);
            var right2 = right.InTermsOf(left);

            return new Fraction(left2.Numerator - right2.Numerator, left2.Denominator);
        }
        public static Fraction operator *(Fraction left, Fraction right)
        {
            return new Fraction(left.Numerator * right.Numerator, left.Denominator * right.Denominator);
        }

        public static Fraction operator /(Fraction left, Fraction right)
        {
            return new Fraction(left.Numerator * right.Denominator, left.Denominator * right.Numerator);
        }

        public override string ToString()
        {
            return (Numerator / (Denominator * 1.0m)).ToString();
        }


    }
}
