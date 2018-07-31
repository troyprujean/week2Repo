using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2Square
{
    public class SquareMethods
    {
        public static double GetSquareValues()
        {
            Console.WriteLine("Please enter the height or width of the square:");
            double squareValue = double.Parse(Console.ReadLine());
            return squareValue;
        }

        public static double CalcSquareArea()
        {
            return GetSquareValues() * GetSquareValues();
        }
    }
    public class Program
    {
        static double squareArea;
        public static void Main()
        {
            squareArea = SquareMethods.CalcSquareArea;
        }
    }
}
