using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace braktal
{
    class Fraction
    {
        private int _num;
        private int _den;
        public Fraction(int num, int den)
        {
            _num = num;
            if (den <= 0) { 
            throw new IndexOutOfRangeException("Nämnaren är noll");
            }
            _den = den;

        }
        public int getNumerator()
        {
            return _num;
        }
        public int getDenominator()
        {
            return _den;
        }
        public bool isNegative(int numerator)
        {

            if (numerator < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Fraction add(Fraction frac)
        {
            int num1 = this.getNumerator();
            int num2 = frac.getNumerator();
            int den1 = this.getDenominator();
            int den2 = frac.getDenominator();

            if (den1 == den2)
            {
                Fraction answer = new Fraction(den1, (num2 + num1));
                return answer;
            }
            else {
                Fraction answer = new Fraction((num1 * den2) + (num2 * den1), den1 * den2);
                return answer;
            }
            

        }
        public Fraction multiply(Fraction frac)
        {
            int num1 = this.getNumerator();
            int num2 = frac.getNumerator();
            int den1 = this.getDenominator();
            int den2 = frac.getDenominator();

            Fraction frac3 = new Fraction((num1*num2), (den1*den2));
            return frac3;
        }

        public bool isEqualTo(Fraction frac)
        {
            int num1 = this.getNumerator();
            int num2 = frac.getNumerator();
            int den1 = this.getDenominator();
            int den2 = frac.getDenominator();

            if (num1 == num2 && den1 == den2) {
                return true;
            }
            else {
                return false;
            };
        }
        public string toString() {
            int numerator = this.getNumerator();
            int denominator = this.getDenominator();
            
            return string.Format("{0}/{1}", numerator, denominator);
        }

    }
}
