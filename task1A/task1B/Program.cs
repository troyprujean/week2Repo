using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in two numbers and I will multiply them together");
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The result of " + num1 + " x " + num2 + " = " + MultiplyNums(num1, num2));
        }

        public static int MultiplyNums(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
