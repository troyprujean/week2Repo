using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MultiplyNums());
        }

        public static int MultiplyNums ()
        {
            Console.WriteLine("Please enter in two numbers and I will multiply them together");
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            return num1 * num2;
        }
    }
}
