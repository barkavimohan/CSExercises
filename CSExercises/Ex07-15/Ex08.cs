using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double F;
            Console.Write("please enter the temparature in C : ");
            double C = Convert.ToDouble(Console.ReadLine());
            F = 1.8* C +32;
            Console.WriteLine("The temparature in fahrenheit is" + F);
            Console.ReadLine();
            
        }
    }
}
