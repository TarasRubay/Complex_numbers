using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_numbers
{
    public class ComplexNum
    {
        readonly double real_part = 0.0;
        readonly double imaginary_part = 0.0;


        public ComplexNum() { }
        public ComplexNum(double A, double B)
        {
            real_part = A;
            imaginary_part = B;
        }

        public double Real_part => real_part;

        public double Imaginary_part => imaginary_part;



        public override bool Equals(object obj)
        {
            return obj is ComplexNum num &&
                   Real_part == num.Real_part &&
                   Imaginary_part == num.Imaginary_part;
        }

        public override int GetHashCode() => (this.Real_part + this.Imaginary_part).ToString().GetHashCode();
        public static bool operator==(ComplexNum a, ComplexNum b){
            if (a.Imaginary_part == b.Imaginary_part && a.Real_part == b.Real_part) return true;
            else return false;
        }
        public static bool operator!=(ComplexNum first, ComplexNum last){
            if (first.Imaginary_part != last.Imaginary_part && first.Real_part != last.Real_part) return false;
            else return true;
        }
        public static ComplexNum operator +(ComplexNum first,ComplexNum last)
        {
            return new ComplexNum(first.Real_part + last.Real_part,first.Imaginary_part + last.Imaginary_part);
        }
        public static ComplexNum operator -(ComplexNum first, ComplexNum last)
        {
            return new ComplexNum(first.Real_part - last.Real_part, first.Imaginary_part - last.Imaginary_part);
        }
        public static ComplexNum operator *(ComplexNum first, ComplexNum last)
        {
            return new ComplexNum((first.Real_part * last.Real_part) - (first.Imaginary_part * last.Imaginary_part),(first.Imaginary_part * last.Real_part) + (first.Real_part * last.Imaginary_part));
        }
        public static ComplexNum operator /(ComplexNum first, ComplexNum last)
        {
            return new ComplexNum(((first.Real_part * last.Real_part) + (first.Imaginary_part * last.Imaginary_part)) / (Math.Sqrt(last.Real_part) + Math.Sqrt(last.Imaginary_part)),
                (first.Imaginary_part * last.Real_part) - (first.Real_part * last.Imaginary_part) / (Math.Sqrt(last.Real_part) + Math.Sqrt(last.Imaginary_part)));
        }
        public static explicit operator double(ComplexNum CN)
        {
            return (double)CN.Real_part + CN.Imaginary_part;
        }
        public static explicit operator ComplexNum(double num)
        {
            return new ComplexNum(num,0);
        }
        public override string ToString()
        {
            return $"{Real_part} + {Imaginary_part}i";

            
        }
    }
}
