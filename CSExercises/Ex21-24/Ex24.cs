using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            string S = "$%$$ab%c%s%s";
            char[] C = new char[] { 's', '%' };
            Console.WriteLine("*" + S + "*");
            string R = S.Trim(C);
            Console.WriteLine("*" + R + "*");
        }
    }
}
