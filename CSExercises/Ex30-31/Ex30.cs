using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int i, n;
            for (n = 5; n <= 10000; n++)
            {
                int count = 0;
                for (i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        count = count + 1;
                    }
                }
                    if (count == 0)
                    {
                       Console.WriteLine("{0}",n);
                   
                    }
                
            }

        }

    }
}


        