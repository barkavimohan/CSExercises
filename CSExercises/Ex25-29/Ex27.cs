using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            int i, j, Y = 0, X = 0;
            Console.Write("X                        ");
            Console.Write("Y");
            Console.Write("\n\n---------------------------------------");
            for (i = -5; i <= 5; i++)
            {
                X = i;
                Y = 2 * i * i - 4 * i + 3;
                Console.Write("\n\n" + X);
                Console.Write("\t\t\t" + Y);
            }
            Console.WriteLine("\n\t");
            for (i = -5; i < 5; i++)
            {

                Y = 2 * i * i - 4 * i + 3;


                for (j = 1; j <= Y; j++)
                {
                    /*X = j;
                    Y = 2 * j * j - 4 * j + 3;
                    Console.Write("*******( "+ X + " times total)*******");
                    Console.Write("*******( "+ Y + " times total)*******");*/
                    Console.Write("*");

                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();


            }
        }
    }


