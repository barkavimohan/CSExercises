using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the string: ");
            string s = Console.ReadLine();
            Console.WriteLine("enter the c1: ");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter the c2: ");
            char c2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("new word is " + Substitute(s,c1,c2));        
            Console.ReadLine();
        }
        public static string Substitute(string s, char c1, char c2)
        {
            char[] c= s.ToCharArray();
                 for (int i = 0; i < c.Length;i++)
                 {
                     if(c[i] == c1)
                     {
                        c[i]=c2;
                     }
                 }
             string s1 = new string(c);
             return s1;
          
           
        }
    }
}
