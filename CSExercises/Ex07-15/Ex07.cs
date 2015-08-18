using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double salary;
            double Total;
            Console.WriteLine("enter the salary:");
            salary = Convert.ToDouble(Console.ReadLine());
            Total = salary + 0.1 * salary + 0.03 * salary;
            Console.WriteLine("The total income is" + Total);
        }
    }
}
