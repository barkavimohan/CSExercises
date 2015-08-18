using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            int X,Y;
            Console.WriteLine("Enter the value of X: ");
            X = Convert.ToInt32(Console.ReadLine());
            Y = 2 * X * X - 4* X + 3;
            Console.WriteLine("the value of y is"+Y);
        }
    }
}
