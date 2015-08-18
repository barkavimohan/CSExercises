using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            int X1, X2, Y1, Y2,X,Y,XY;
            double Distance;
            Console.Write("enter the value for X1 : ");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the value for y1 : ");
            Y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the value for x2 : ");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the value for Y2 : ");
            Y2 = Convert.ToInt32(Console.ReadLine());
            X = (X2 - X1) * (X2 - X1);
            Y = (Y2 - Y1) * (Y2 - Y1);
            XY = X + Y;
            Distance = System.Math.Sqrt(X + Y);
            Console.WriteLine("The distance is {0:00.000}" , Distance);
            Console.ReadLine();


        }
    }
}
