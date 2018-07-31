using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2Circle;
//using task2Square;

namespace task2Menu
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the area machine");
            Console.WriteLine("Would you like to calculate the area of a circle or square? type circle or square into the console");
            string programType = Console.ReadLine();

            switch (programType)
            {
                case "circle":
                    task2Circle.Program.Main();
                    break;
                //case "square":
                    //task2Square.Program.Main();
                   // break;
                default:
                    Console.WriteLine("Incorret input, please try again");
                    break;
            }
        }
    }
}
