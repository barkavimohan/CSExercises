using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            string phrase;
            Console.Write("please enter a phrase : ");
            phrase = Console.ReadLine();
            char[] c = phrase.ToCharArray();
            //string vowels;
            //char[] v = vowels.ToCharArray();
            //char[] v = new char[] { 'a', 'e', 'i', 'o', 'u' };
            
            int i, total = 0; int j;
            for (i = 0; i < c.Length; i++)
            {
                /* if (c[i] == 'a')
                 {
                     count = count + 1;
                 }
                 else if (c[i] == 'e')
                 {
                     count = count + 1;
                 }
                 else if (c[i] == 'i')
                 {
                     count = count + 1;
                 }
                 else if (c[i] == 'o')
                 {
                     count = count + 1;
                 }
                 else if (c[i] == 'u')
                 {
                     count = count + 1;
                 }*/
                if (c[i] == 'a' || c[i] == 'e' || c[i] == 'i' || c[i] == 'o' || c[i] == 'u')
                {
                    total = total + 1;
                    int count = 0;
                    for (j = 0; j < c.Length; j++)
                    {

                        if (c[i] == c[j])
                        {
                            count = count+1;
                        }
                    }
                    Console.WriteLine("number of {0} is {1}",c[i],count);
                }
            }
            Console.WriteLine("total number of vowels is " + total);

            Console.ReadLine();

            }
        }
    }

   
                   
    
        
    

