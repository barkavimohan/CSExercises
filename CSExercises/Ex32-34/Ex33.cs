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
            int i;
            int[] number = new int[10];
            for (int j = 0; j < number.Length; j++)
            {
                Console.WriteLine("Enter the no ");
                number[j] = Convert.ToInt32(Console.ReadLine());

            }
            int n = number.Length;
            Console.Write("Given List");
            for (i = 0; i < n; i++)
            {
                Console.Write(" " + number[i]);
            }
            Console.WriteLine("\n");
            for (i = 0; i < n; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (number[i] < number[j])
                    {
                        int temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;

                    }
                    {
                        Console.Write(" " + number[i]);

                    }

                }


            }
            Console.Write("Sorted list");
            for (i = 0; i < n; ++i)
            {
                Console.Write(" " + number[i]);

            }
            Console.WriteLine(" ");
            Console.ReadLine();
        }
    }
}
