using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double area,S,sa,sb,sc;
            Console.WriteLine("enter the value of A: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the value of C: ");
            double C = Convert.ToDouble(Console.ReadLine());
            S = (A + B + C) / 2;
            sa = S - A;
            sb = S - B;
            sc = S - C;
            area = System.Math.Sqrt(S * sa * sb * sc);
            Console.WriteLine("area of triangle is " + area);
            Console.ReadLine();

        }
    }
}