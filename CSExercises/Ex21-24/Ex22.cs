using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int n1, n2,HCF,LCM;
            Console.WriteLine("enter the number A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            n1 = A;
            n2 = B;
            /* t = n2;
             if(n1>n2)
             {
                 while(n1!=n2)
                 {
                 n1=n1-n2;
                 }
             }
                 else
                     while(n2!=n1)
                     {
                         n2=n2-n1;
                     }*/
             
            while(n1!=n2)
            {
                if (n1 > n2)
                    n1 = n1 - n2;
                else
                    n2 = n2 - n1;
            }

            HCF = n2;
            LCM = (A * B) / HCF;
            Console.WriteLine("HCF: " + HCF);
            Console.WriteLine("LCM: " + LCM);
            Console.ReadLine();

        }
    }
    }

