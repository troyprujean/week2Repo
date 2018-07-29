using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1D
{
    class Math
    {
        public static int MultiplyNums(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int AddNums(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int SubtractNums(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int DivideNums(int num1, int num2)
        {
            return num1 / num2;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter in two numbers and I will calculate them together depending on the operator you provide");
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the math function e.g. +  -  /  or * :");
            char mathFunction = char.Parse(Console.ReadLine());

            switch (mathFunction)
            {
                case '+':
                    Console.WriteLine("The result of {0} {1} {2} = {3}", num1, mathFunction, num2, Math.AddNums(num1, num2));
                    break;
                case '-':
                    Console.WriteLine("The result of {0} {1} {2} = {3}", num1, mathFunction, num2, Math.SubtractNums(num1, num2));
                    break;
                case '*':
                    Console.WriteLine("The result of {0} {1} {2} = {3}", num1, mathFunction, num2, Math.MultiplyNums(num1, num2));
                    break;
                case '/':
                    Console.WriteLine("The result of {0} {1} {2} = {3}", num1, mathFunction, num2, Math.DivideNums(num1, num2));
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
    }
}
