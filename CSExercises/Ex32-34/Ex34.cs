using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] marks = new int[12, 4]
            {
	            {56,84,68,29},
	            {94,73,31,89},
                {41,63,36,90},
                {99,9,18,17},
                {62,3,65,75},
                {40,96,53,23},
                {81,15,27,30},
                {21,70,100,22},
                {88,50,13,12},
                {48,54,52,78},
                {64,71,67,25},
                {16,93,46,72}

	         };

            Console.WriteLine("\n\t\t\tSTUDENT MARK LIST\n");
            Console.WriteLine("\t\t\t-----------------\n");
            Console.WriteLine("STUD NO\tSUB1\tSUB2\tSUB3\tSUB4\tTOTAL");
            int total = 0;
            for (int i = 0; i < 12; i++)
            {
                int sum = 0;
                Console.Write(i + 1);
                for (int j = 0; j < 4; j++)
                {
                    sum = sum + marks[i, j];
                    total = total + marks[i, j];
                    Console.Write("\t" + marks[i, j]);
                }

                Console.WriteLine("\t" + sum);
                Console.WriteLine("\n");
            }

            double[] avg = new double[4];
            for (int i = 0; i < 4; i++)
            {
                int msum = 0;
                avg[i] = 0;
                for (int j = 0; j < 12; j++)
                {
                    msum = msum + marks[j, i];
                }
                avg[i] = avg[i] + msum / 12;
                Console.Write("\t{0} ", avg[i]);
            }
            Console.WriteLine("\n");

            for (int i = 0; i < 4; i++)
            {

                double v = 0, var = 0, sd = 0, msum = 0;
                for (int j = 0; j < 12; j++)
                {
                    msum = msum + marks[j, i];

                    v = v + ((marks[j, i] - avg[i]) * (marks[j, i] - avg[i]));
                    var = v / 12;
                    sd = Math.Sqrt(var);
                }
                avg[i] = avg[i] + msum / 12;
                // Console.Write("Average {0} ", avg[i]);
                Console.Write("\t {0:00.00} ", sd);
            }
            Console.WriteLine("\n");
            Console.WriteLine("\noverall average mark for whole class is " + total / 48);


        }
    }
}
