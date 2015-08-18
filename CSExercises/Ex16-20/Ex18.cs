using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the mark between 0 to 100: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            if(mark<=100 && mark>=80)
            {
                Console.WriteLine("you scored " + mark + "marks which is A grade.");
            }
            else if (mark <= 79 && mark >= 60)
            {
                Console.WriteLine("you scored " + mark + "marks which is B grade.");
            }
            else if (mark >= 40 && mark <=59 )
            {
                Console.WriteLine("you scored " + mark + "marks which is C grade.");
            }
            else if (mark >= 0 && mark <= 39)
            {
                Console.WriteLine("you scored " + mark + "marks which is F grade.");
            }
            else
            {
                Console.WriteLine("**ERROR**");
            }
        }
    }
}