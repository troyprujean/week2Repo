using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Math
    {
        public static int MultiplyNums(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int DivideNums(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int AddNums(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int SubtractNums(int num1, int num2)
        {
            return num1 - num2;
        }
    }


    public class Program
    {
        static int num1;
        static int num2;
        static int menuChoice;
        static int menuChoice2;
        static bool repeat = false;
        public static void Main()
        {
            while (!repeat)
            {
                bool isNumber = false;
                bool isNumber2 = false;
                bool isNumber3 = false;
                Console.WriteLine("Welcome to the simple calculator");
                while (!isNumber)
                {
                    Console.WriteLine("Please enter the first number:");
                    string userInput = Console.ReadLine();
                    if (int.TryParse(userInput, out num1))
                    {
                        isNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please try again");
                        isNumber = false;
                    }
                }

                while (!isNumber2)
                {
                    Console.WriteLine("Please enter the second number:");
                    string userInput = Console.ReadLine();
                    if (int.TryParse(userInput, out num2))
                    {
                        isNumber2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please try again");
                        isNumber2 = false;
                    }
                }
                Console.Clear();

                while (!isNumber3)
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("(1) Add");
                    Console.WriteLine("(2) Subtract");
                    Console.WriteLine("(3) Multiply");
                    Console.WriteLine("(4) Divide");
                    Console.WriteLine("(5) Exit");
                    string userInput = Console.ReadLine();
                    if (int.TryParse(userInput, out menuChoice))
                    {
                        if (menuChoice > 5)
                        {
                            Console.WriteLine("Invalid input, please try again");
                            isNumber = false;
                        }
                        else isNumber3 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please try again");
                        isNumber3 = false;
                    }
                }

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("The result of {0} + {1} = {2}", num1, num2, Math.AddNums(num1, num2));
                        ClearScreen();
                        repeat = RepeatMenu();
                        break;
                    case 2:
                        Console.WriteLine("The result of {0} - {1} = {2}", num1, num2, Math.SubtractNums(num1, num2));
                        ClearScreen();
                        repeat = RepeatMenu();
                        break;
                    case 3:
                        Console.WriteLine("The result of {0} * {1} = {2}", num1, num2, Math.MultiplyNums(num1, num2));
                        ClearScreen();
                        repeat = RepeatMenu();
                        break;
                    case 4:
                        Console.WriteLine("The result of {0} / {1} = {2}", num1, num2, Math.SubtractNums(num1, num2));
                        ClearScreen();
                        repeat = RepeatMenu();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Thank you for using my calculator, see you next time!");
                        break;
                    default:
                        break;
                }
            }

        }

        static bool RepeatMenu()
        {
            bool isNumber4 = false;

            while (!isNumber4)
            {
                Console.Clear();
                Console.WriteLine("Would you like to use the simple calculator again or return to main menu?");
                Console.WriteLine("(1) Simple Calculator");
                Console.WriteLine("(2) Main Menu");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out menuChoice2))
                {
                    if (menuChoice2 > 2)
                    {
                        Console.WriteLine("Invalid input, please try again");
                        isNumber4 = false;
                    }
                    else isNumber4 = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again");
                    isNumber4 = false;
                }
            }
            if (menuChoice2 == 1)
            {
                return false;
            }
            else return true;
        }

        static void ClearScreen()
        {
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear(); 
        }
    }
}
