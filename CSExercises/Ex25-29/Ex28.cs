using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
        
            int i,n,j;
            Console.Write("enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = n; i <= n; i++)
            {
                int count = 0;
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count = count + 1;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("this is a prime number ");
                }
                else 
                {
                    Console.WriteLine("this is not a prime number ");
                }
            }
        }
    }
}
