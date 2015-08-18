using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            double total;
            Console.WriteLine("enter the distance: ");
            double d = Convert.ToDouble(Console.ReadLine());
            total = 2.40 + d * 0.4;
            Console.WriteLine("The total fare for the distance is: "+ total);
            Console.ReadLine();
        }
    }
}
