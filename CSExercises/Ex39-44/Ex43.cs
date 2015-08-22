using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
           
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("hexadecimal of {0} is {1}               built in value = {2} ", i, Hex(i),i.ToString("X"));
            }

            Console.ReadLine();
        }
        public static string Hex(int n)
        {
            //int n;
            string s="";
            do
            {
                
                if (n % 16 > 9)
                {
                    switch (n%16)
                    {
                        case 10: s = s + "A";
                            break;
                        case 11: s = s + "B";
                            break;

                        case 12: s = s + "C";
                            break;
                        case 13: s = s + "D";
                            break;
                        case 14: s = s + "E";
                            break;
                        case 15: s = s + "F";
                            break;
                        default: s = s + "";
                            break;
                    }
                }
                else
                {
                    s = s + n % 16;
                }
                n = n / 16;
            } while (n > 0);
            char[] c = s.ToCharArray();
            string reverse="";
            for(int i=c.Length-1;i>=0;i--)
            {
                reverse = reverse + c[i];
            }
                  return reverse;          
            
        }
    
    }
}
        