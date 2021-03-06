using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tRANDOM NUMBER OCCURRENCES\n");
            int[,] n = new int[10, 10]
            {
                {10,34,90,12,11,9,4,56,84,68},
                {94,73,31,89,23,34,65,66,77,11},
                {41,63,36,90,7,45,44,66,99,10},
                {99,9,18,17,31,89,23,34,63,36},
                {62,3,65,75,11,87,55,33,9,2},
                {40,96,53,23,24,46,58,11,98,21},
                {81,15,27,30,21,54,87,32,16,54},
                {21,70,100,22,31,45,66,54,23,3},
                {88,50,13,12,31,87,10,65,49,62},
                {48,54,52,78,54,42,12,35,43,15},      
            };

            Random r = new Random();
            int[] ran = new int[50];
            int[] occ = new int[50];
            for(int i = 0;i<50;i++)
            {
                ran[i] = r.Next(1, 101);
                occ[i] = 0;
                for(int j=0;j<10;j++)
                {
                    for(int k=0;k<10;k++)
                    {
                        if(ran[i]==n[j,k])
                        {
                            occ[i] = occ[i] + 1;
                        }

                    }

                }
                Console.WriteLine("\t" + ran[i] + "\t" + occ[i]);

            }
            Console.ReadLine();
        }
    }
}
