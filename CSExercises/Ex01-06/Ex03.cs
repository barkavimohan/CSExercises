using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            double number;
            Console.Write("enter a number: ");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("square of the number is "+ number * number);
        }
    }
}
