using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            double r = amt * 100;
            int s = Convert.ToInt32(r);
            Console.WriteLine(s / 100 + "100c");
           
                if (r % 10 > 5)
                {
                    r = r - (r % 10) + 10;
                }
                else
                {
                    r = r - (r % 10);
                }
                Console.WriteLine(r);

                do
                {
                if (s % 10 == 5)
                {
                    s = s - 5;
                    Console.WriteLine("5c");
                }
                else if (s % 100 >= 50)
                {
                    s = (s%100) - 50;
                    Console.WriteLine("50c");
                }
                else if (s % 100 >= 20)
                {
                    s = (s%100) - 20;
                    Console.WriteLine("20c");
                }
                else if (s % 100 >= 10)
                {
                    s = (s%100) - 10;
                    Console.WriteLine("10c");
                }
            } while (s > 0);
           // Console.ReadLine();
        }
    }
}
