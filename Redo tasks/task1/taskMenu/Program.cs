using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1;
using task2;

namespace taskMenu
{
    public class Program
    {
        static int menuChoice;
        
        static void Main()
        {
            bool repeat = false;
            Console.WriteLine("Welcome to Troy's calculator");
            while (!repeat)
            {
                bool isNumber = false;
                while (!isNumber)
                {
                    Console.WriteLine("Please enter one of the options below");
                    Console.WriteLine("(1) Simple calculator");
                    Console.WriteLine("(2) Area calculator");
                    Console.WriteLine("(3) Exit");
                    string userInput = Console.ReadLine();
                    if (int.TryParse(userInput, out menuChoice))
                    {
                        if (menuChoice > 3)
                        {
                            Console.WriteLine("Invalid input, please try again");
                            isNumber = false;
                        }
                        else isNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please try again");
                        isNumber = false;
                    }
                }
                switch (menuChoice)
                {
                    case 1:
                        task1.Program.Main();
                        break;
                    case 2:
                        task2.Program.Main();
                        break;
                    case 3:
                        break;
                }

            }
        }
    }
}
