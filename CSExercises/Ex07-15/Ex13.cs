﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            double total, f1, fare,f3;
            int f2 ;
            Console.Write("enter the distance: ");
            double d = Convert.ToDouble(Console.ReadLine());
            total = 2.40 + d * 0.4;
            Console.WriteLine("The total fare for the distance is: " + total);
            f1 = (total * 100);
            f2 = Convert.ToInt32(f1 / 10);
            f3 = f2 + 1;
            fare = Convert.ToDouble(f3/10);
            Console.WriteLine("the fare is " + fare);
            Console.ReadLine();
        }
    }
}
