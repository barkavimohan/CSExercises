using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the gender: ");
            string gender = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (gender == "male")
            {
                if (age >= 40)
                    Console.Write("Good morning" + "uncle" + name);
                else
                    Console.Write("Good morning" + "Mr." + name);

            }
            else if (gender == "female")
            {
                if (age >= 40)
                    Console.Write("Good morning" + "aunty" + name);
                else
                    Console.Write("Good morning" + "Ms." + name);

            }
            else
            {
                Console.WriteLine("There is an error");
            }

        }

    }

}