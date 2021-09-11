using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNum z = new ComplexNum(1,1);
            ComplexNum z1;
            z1 = z - (z * z * z - (ComplexNum)1) / ((ComplexNum)3 * z * z);
            Console.WriteLine("z1 = z - (z * z * z - 1) / (3 * z * z)");
            Console.WriteLine($"z1 = {z1}");
            Console.ReadKey();
        }
    }
}
