using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            if (Denominator == 0) throw new Exception("Invalid input for denominator");
        }

        public static Fraction Input(int numerator, int denominator) 
        {
            return new Fraction(numerator, denominator);
        }

        public void Print ()
        {
            Console.WriteLine($"Print fraction:{Numerator}/{Denominator}");
        }
        
        public Fraction Reduce()
        {
            if (Numerator == 0) return this;
            else if (Numerator == Denominator) return new Fraction(1,1);
            else
            {
                var temp = Denominator >= Numerator ? Denominator / Numerator : Numerator / Denominator;
                return new Fraction(Numerator/temp,Denominator/temp);
            }
        }

        public Fraction Reverse()
        {
            return new Fraction(Denominator, Numerator);
        }

        public Fraction Add(Fraction f)
        {
            return new Fraction(Numerator * f.Denominator + f.Numerator * Denominator, Denominator * f.Denominator).Reduce();
        }      
        public Fraction Sub(Fraction f)
        {
            return new Fraction(Numerator * f.Denominator - f.Numerator * Denominator, Denominator * f.Denominator).Reduce();
        }        
        public Fraction Mul(Fraction f)
        {
            return new Fraction(Numerator * f.Numerator, Denominator * f.Denominator).Reduce();
        }
        public Fraction Mul(Fraction f)
        {
            if (f.Numerator == 0) throw new ArgumentException("Can't divide for a fraction with numerator equals 0");
            return new Fraction(Numerator * f.Denominator, Denominator * f.Numerator).Reduce();
        }
    }
}
