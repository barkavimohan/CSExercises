using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            string s1, s2;
            Console.WriteLine("enter string1: ");
            s1 = Console.ReadLine();
            Console.WriteLine("enter string2: ");
            s2 = Console.ReadLine();
            Console.WriteLine("result is "+ InString(s1,s2));
            Console.ReadLine();
        }
        public static bool InString(string s1, string s2)
        {
            bool result;
            if( s1 . Contains (s2))
            {
                result=true;
            }
            else
            {
             result=false;
                
            }
            return result;
        }
    }
}