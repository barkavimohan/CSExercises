using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            int number;
            double squareroot;
            Console.Write("enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            squareroot = System.Math.Sqrt(number);
            Console.Write("square root of {0} is " + squareroot, number);
          
        }
    }
}
