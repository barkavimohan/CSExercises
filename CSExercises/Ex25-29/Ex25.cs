using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int n, i,j, num = 1,num1=1;
            Console.WriteLine("enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = n ; i >= 1 ; i--)
            {
                num = num * i;
            }
            for (j = 1; j <= n; j++)
            {
                num1 = num1 * j;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + num);
            Console.WriteLine("\nFactorial of Given Number is: " + num1);
            Console.ReadLine();
            
        }
    }
}
