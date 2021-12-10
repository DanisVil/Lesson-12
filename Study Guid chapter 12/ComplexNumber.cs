using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Guid_chapter_12
{
    class ComplexNumber
    {
        public double real, imaginary;
        public ComplexNumber(double re, double im)
        {
            real = re;
            imaginary = im;
        }
        public static ComplexNumber operator +(ComplexNumber first, ComplexNumber second)
        {
            return new ComplexNumber(first.real + second.real, first.imaginary + second.imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber first, ComplexNumber second)
        {
            return new ComplexNumber(first.real - second.real, first.imaginary - second.imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber first, ComplexNumber second)
        {
            return new ComplexNumber(first.real * second.real - first.imaginary * second.imaginary,
                first.real * second.imaginary + first.imaginary * second.real);
        }
        public static bool operator ==(ComplexNumber first, ComplexNumber second)
        {
            if (first.real == second.real && first.imaginary == second.imaginary)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(ComplexNumber first, ComplexNumber second)
        {
            return !(first == second);
        }
        public override bool Equals(object obj)
        {
            ComplexNumber number = obj as ComplexNumber;
            if (number is null)
            {
                return false;
            }
            if (real.Equals(number.real) && imaginary.Equals(number.imaginary))
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            int hash = 27011;
            hash = hash * 27751 + real.GetHashCode();
            hash = hash * 27751 + imaginary.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            return $"({real}) + i({imaginary})";
        }
    }
}
