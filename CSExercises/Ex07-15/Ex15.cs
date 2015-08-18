using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int d1, s1, s2, s3, d2, d3, sum;
            Console.WriteLine("enter a three digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            d1 = num % 10;
            s1 = d1 * d1 * d1;
            d2 = (num / 10) % 10;
            s2 = d2 * d2 * d2;
            d3 = num / 100;
            s3 = d3 * d3 * d3;
            sum = s1 + s2 + s3;

            if (sum==num)
            {
                Console.Write("this is an armstrong number");
            }
            else
            {
                Console.Write("this is not an armstrong number");
            }


        }
    }
}