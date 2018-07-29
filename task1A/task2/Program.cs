using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class SquareMethods
    {
        public static int GetSquareValues()
        {
            Console.WriteLine("Please enter the height or width of the square:");
            int squareValue = int.Parse(Console.ReadLine());
            return squareValue;
        }

        public static int CalcSquareArea()
        {
            return GetSquareValues() * GetSquareValues();
        }
    }

    class CircleMethods
    {
        public static int GetCircleValues()
        {
            Console.WriteLine("Please enter the radius of the circle:");
            int circleRadius = int.Parse(Console.ReadLine());
            return circleRadius;
        }

        public static double CalcCircleArea()
        {
            double pi = Math.PI;
            return pi * (GetCircleValues() * GetCircleValues());
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the area machine");
            Console.WriteLine("Would you like to calculate the area of a circle or square? type circle or square into the console");
            string calcType = Console.ReadLine();

            switch (calcType)
            {
                case "circle": Console.WriteLine("The area of the circle is: " + CircleMethods.CalcCircleArea());
                    break;
                case "square": Console.WriteLine("The area of the square is: " + SquareMethods.CalcSquareArea());
                    break;
                default: Console.WriteLine("Incorret input, please try again");
                    break;
            }
        }
    }
}
