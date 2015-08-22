using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.RV.LIB;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            double N,sq;
            Console.WriteLine("enter a number: ");
            N = Convert.ToDouble(Console.ReadLine());
            int n = Convert.ToInt32(N);
            sq = System.Math.Sqrt(N);
            Console.WriteLine("squareroot of {0} is {1} ", N , sq);
            double G = Convert.ToDouble(Console.ReadLine());
            Random r = new Random();
            G = r.NextDouble();
            G = G * (N - 1);
            G = G + 1;           
            Console.WriteLine("guess the NUM on mind : ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != G)
            {
                int cnt = 0;
                cnt = Convert.ToInt32(cnt + 1);
                Console.WriteLine("please try again");
                Console.WriteLine("guess the NUM on mind : ");
                num = Convert.ToInt32(Console.ReadLine());
            }                       
                Console.WriteLine("CONGRATS..You have guessed the number");
                do
                {
                    if (G * G == n)
                    {
                        Console.WriteLine("yes {0} is a squareroot", G);
                        break;
                    }
                    else
                    {
                        G = (G + (n / G)) / 2;
                    }
                } while (G * G != n);
            }
            
        }
    }

