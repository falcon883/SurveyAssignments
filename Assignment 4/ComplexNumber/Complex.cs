using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        public override string ToString()
        {
            if (Imag >= 0)
                return Real.ToString() + " + i" + Imag.ToString();
            else
                return Real.ToString() + " - i" + Math.Abs(Imag).ToString();
        }

        // Addition operator
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            Complex res = new Complex();
            res.Real = lhs.Real + rhs.Real;
            res.Imag = lhs.Imag + rhs.Imag;
            return res;
        }

        // Subtraction operator
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            Complex res = new Complex();
            res.Real = lhs.Real - rhs.Real;
            res.Imag = lhs.Imag - rhs.Imag;
            return res;
        }

        // Multiplication operator
        public static Complex operator *(Complex lhs, Complex rhs)
        {
            Complex res = new Complex();
            res.Real = lhs.Real * rhs.Real - lhs.Imag * rhs.Imag;
            res.Imag = lhs.Real * rhs.Imag + lhs.Imag * rhs.Real;
            return res;
        }

        // Division operator
        public static Complex operator /(Complex lhs, Complex rhs)
        {
            if (rhs.Real == 0 && rhs.Imag == 0)
                throw new DivideByZeroException("Cannot divide by zero complex number");

            Complex res = new Complex();
            double denominator = rhs.Real * rhs.Real + rhs.Imag * rhs.Imag;
            res.Real = (lhs.Real * rhs.Real + lhs.Imag * rhs.Imag) / denominator;
            res.Imag = (lhs.Imag * rhs.Real - lhs.Real * rhs.Imag) / denominator;
            return res;
        }

        // Equality operator
        public static bool operator ==(Complex lhs, Complex rhs)
        {
            if ((lhs.Real == rhs.Real) && (lhs.Imag == rhs.Imag))
                return true;
            else
                return false;
        }

        // Inequality operator
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            if ((lhs.Real != rhs.Real) || (lhs.Imag != rhs.Imag))
                return true;
            else
                return false;
        }

        // Pre-increment operator
        public static Complex operator ++(Complex c)
        {
            c.Real++;
            return c;
        }

        // Pre-decrement operator
        public static Complex operator --(Complex c)
        {
            c.Real--;
            return c;
        }

        // Override Equals for better equality comparison
        public override bool Equals(object? obj)
        {
            return obj is Complex c && this == c;
        }

        // Override GetHashCode
        public override int GetHashCode()
        {
            return Real.GetHashCode() ^ Imag.GetHashCode();
        }
    }
}