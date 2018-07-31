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
        static string menuChoice;
        
        static void Main()
        {
            Console.WriteLine("Welcome to Troy's calculator");
            do
            {
                Console.WriteLine("Please enter one of the options below");
                Console.WriteLine("(simple) Simple calculator");
                Console.WriteLine("(area) Area calculator");
                Console.WriteLine("(exit) Exit");
                menuChoice = Console.ReadLine();

                if (menuChoice != "simple" || menuChoice != "area" || menuChoice != "exit")
                {
                    Console.WriteLine("Incorrect input, please press any key and then try again");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    switch (menuChoice)
                    {
                        case "simple":
                            task1.Program.Main();
                            break;
                        case "area":
                            task2.Program.Main();
                            break;
                        case "exit":
                            break;
                    }
                }
            } while (menuChoice != "simple" || menuChoice != "area" || menuChoice != "exit");
        }
    }
}
