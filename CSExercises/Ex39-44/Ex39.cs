using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            double n = Convert.ToDouble(Console.ReadLine());
           /*for (double i = n; i >=1;i-- )
            {
                f = f * i;
            }*/
            Console.WriteLine("factorial = {0} ",Factorial( n));
            // Console.WriteLine("factorial = {0}  ",f);
            Console.ReadLine();
        }
        public static double Factorial(double n)
        {
            double f=1;

            for (double i = 1; i <= n;i++ )
            {
                f = f * i;
            }
                  return f;
       
        }
    }

}
