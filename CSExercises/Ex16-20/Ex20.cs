using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            double FT;
            Console.WriteLine("enter the quantity for TV : ");
            int TV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the quantity for DVD : ");
            int DVD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the quantity for MP3 : ");
            int MP3 = Convert.ToInt32(Console.ReadLine());
            int CT = Convert.ToInt32(TV * 900);           
            int CD = Convert.ToInt32(TV * 500);            
            int CM = Convert.ToInt32(TV * 700);
            int total = CT + CD + CM;
            int TD = CT + CD;
            if (total >= 5000)
            {
                 FT = Convert.ToDouble((TD - (0.01 * TD)) + CM);
                 Console.WriteLine("cost of Mp3 is" + CM);
                 Console.WriteLine("cost of TV is" + CT);
                 Console.WriteLine("cost of DVD is" + CD);
                 Console.WriteLine("total price for this order is" + FT);
            }
            else if (total >= 10000)
            {
                 FT = Convert.ToDouble(( TD - (0.15 * TD)) + CM);
                 Console.WriteLine("cost of Mp3 is" + CM);
                 Console.WriteLine("cost of TV is" + CT);
                 Console.WriteLine("cost of DVD is" + CD);
                 Console.WriteLine("total price for this order is" + FT);
            }

            
           
            Console.ReadLine();
        }
    }
}