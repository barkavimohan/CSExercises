using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int i, n;
            for (n=2;n<=1000;n++)
            {
                int count=0;
                for(i=1;i<n;i++)
                {
                    if(n%i==0)
                    {
                      count=count+i;
                    }
                }
                    if(count==n)
                    {
                     Console.WriteLine("the perfect number is "+n);
                    }
                    
            }
        }
    }
}















