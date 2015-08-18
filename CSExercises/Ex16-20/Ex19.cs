using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double cost,c1,c2,c3;

            Console.Write("enter the distance in km :");
            double d1 = Convert.ToDouble(Console.ReadLine());
            int d2 = Convert.ToInt32((d1*100)/10);
            double d3 =Convert.ToDouble (d2 + 1) /10;
            Console.WriteLine(d3);
            c1 = 0.5;
            c2 = 9.0;
            if(d1<=c1)
            {
                cost = Convert.ToDouble(2.40);
                Console.WriteLine(cost);
            }
            else if(d1<=c2)
            { 
                cost = 2.40 + (8.5*0.04);
                Console.WriteLine(cost);

            }
            else if(d1>c2)
            {
                c3 = (d3 * 1000) / 100;
                cost = 2.40 + (85 * 0.04) + ( (c3 - 90) * 0.05 );
                Console.WriteLine(cost);
            }
            else

            { 
                Console.WriteLine("ERROR");
            }

                Console.ReadLine();
        }
    }
}