using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int i,n,j;
            Console.Write("enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=n;i<=n;i++)
            {
                int count = 0;
                for (j = 1; j < n; j++)
                {
                    if (i % j == 0)
                    {
                        count = count + j;
                    }
                }
                if(count==n)
                {
                    Console.Write("this is a perfect number");
                }
                else
                {
                     Console.Write("this is not a perfect number");
                }
            }
        }
    }
}
