using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] sales = new int[12];
            int i;
            for (i = 0; i < 12; i++)
            {
                Console.WriteLine("enter the sales for the month {0}: ", i+1 );
                sales[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxp = 0;

            for (i = 1; i < 12; i++)
            {
                if (sales[maxp] < sales[i])
                {
                    maxp = i;
                }
            }
            Console.WriteLine("maximum sales: " + sales[maxp]);

            int minp = 0;

            for (i = 1; i < 12; i++)
            {
                if (sales[minp] > sales[i])
                {
                    minp = i;
                }
            }

            Console.WriteLine("minimum sales: " + sales[minp]);
            Console.WriteLine("minimum month of sale is " + minp);
            Console.WriteLine("maximum month of sale is " + maxp);
            double avg =0, sum = 0;
            for (i = 0; i < 12; i++)
            {
                sum = sum + sales[i];
                avg = sum / 12;
            }
            Console.WriteLine("Average sales: " + avg);
           /* for (i = 0; i < 12; i++)
            {
                if (sales[i] == maxp)
                {
                    Console.WriteLine("maximum month of sale is " +i);
                }
                if (sales[i] == minp)
                {
                    Console.WriteLine("minimum month of sale is " +i);
                }*/
                Console.ReadLine();

            }
        }
    }

