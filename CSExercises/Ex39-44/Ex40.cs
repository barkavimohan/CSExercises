using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
       
        {
            int i;            
            for(i=0;i<25;i++)
            {
                Console.WriteLine(SQT(i));
            }
        }
        public static double SQT(int y)
        {
            double sq;
            sq = Math.Sqrt(y);
            return sq;
        }

           
            
        
    }
}
