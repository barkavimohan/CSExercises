using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] num = new int[6];
            int i;
            for (i = 0; i < num.Length; i++)
            {
                Console.WriteLine("enter the number: ");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            int n, j;
            n = num.Length;
            Console.WriteLine("list is: ");
            for (j = 0; j < n; j++)
            {
                Console.Write("\t" + num[j]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (num[i] < num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                    else
                    {
                        Console.WriteLine("\t" + num[i]);
                    }
                }

            }
            Console.Write("Sorted list");
            for (i = 0; i < n; i++)
            {
                Console.Write(" " + num[i]);

            }
            Console.WriteLine(" ");
            Console.ReadLine();
        }
    }
}

