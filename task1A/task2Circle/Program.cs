using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2Circle
{
    public class CircleMethods
    {
        public static double GetCircleValues()
        {
            Console.WriteLine("Please enter the radius of the circle:");
            double circleRadius = double.Parse(Console.ReadLine());
            return circleRadius * circleRadius;
        }

        public static double CalcCircleArea()
        {
            double pi = Math.PI;
            return pi * GetCircleValues();
        }
    }

    public class Program
    {
        public static void Main()
        {
            double circleArea = CircleMethods.CalcCircleArea();
            Console.WriteLine("The area of the circle is {0}", circleArea);
        }
    }
}
