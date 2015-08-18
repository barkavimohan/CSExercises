using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
   public class Ex16
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter the gender: ");
            string gender = Console.ReadLine();
            if (gender == "male")
            {
                Console.WriteLine("good morning " + "Mr. " + name);
            }
            else if (gender == "female")
            {
                Console.WriteLine("good morning " + "Ms. " + name);
            }
            else
            {
                Console.WriteLine("There is an error");
            }

        }

    }
}