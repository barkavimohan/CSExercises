using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex42
    {
    public static void Main(string[] args)
        {
            string s1, s2;
            Console.WriteLine("enter string1: ");
            s1 = Console.ReadLine();
            Console.WriteLine("enter string2: ");
            s2 = Console.ReadLine();
            Console.WriteLine("position of word is {0} ", FindWord(s1, s2));
            Console.ReadLine();
    }
        public static int FindWord(string s1, string s2)
        {
            int result;
            if (s1.Contains(s2))
            {
                result = s1.IndexOf(s2);

            }
            else
            {
                result = -1;
            }
            return result;
        }
    }
}