using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimWeissWeek2Day1
{
    class Program
    {
        //          Create an application that simulates a calculator
        //          Create an application that simulates a calculator.
        //          You must have a static utility class containing all the math functions
        //          (Add, Subtract, Multiply, Divide, Square, Square Root), 
        //          stub the methods in before finalizing the app.
        //          You must handle divide by zero using exception handling(try/catch). 
        //          You must ask the user if they would like to go again & repeat until they say no.
        //
        //          Additional Requirements
        //          Handle bad input
        //          When asking for the numbers to do the math on
        //          When asking if they would like to go again(what if it's not y or n)

        static void Main(string[] args)
        {
            bool moreCalc = true;
            while (moreCalc)
            {
                MenuMaker();
                menuChoice = int.Parse(Console.ReadLine());
                switch (menuChoice)
                {
                    case 1:
                        PrintCalc();
                        Console.WriteLine(Utils.Add(x, y));
                        Console.ReadLine();
                        break;
                    case 2:
                        PrintCalc();
                        Console.WriteLine(Utils.Subtract(x, y));
                        break;
                    case 3:
                        PrintCalc();
                        Console.WriteLine(Utils.Multiply(x, y));
                        break;
                    case 4:
                        PrintCalc();
                        Console.WriteLine(Utils.Divide(x, y));
                        break;
                    case 5:
                        PrintCalc();
                        Console.WriteLine(Utils.Square(x, y));
                        break;
                    case 6:
                        PrintCalc();
                        Console.WriteLine(Utils.SquareRoot(x, y));
                        break;
                }

                CalcContinue();
                //{
                //    if (moreCalc != true)
                //        break;
                //}
            }
            Console.ReadLine();
        }
        public static int menuChoice;
        public static int x;
        public static int y;
        public static bool moreCalc;
        public static void MenuMaker()
        {
            Console.WriteLine("Select from the following choices: \n1. to Add\n2. to Subtract\n3. to Multiply\n4. to Divide\n5. for Square\n6. for Square Root");
        }
        public static void PrintCalc()
        {
            Console.WriteLine("Enter your first number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result");
        }
        public static void CalcContinue()
        {
            Console.WriteLine("Do you want to go again? (y/n)");
            string answer = Console.ReadLine();
            if (answer != "y")
                moreCalc = false;
        }
    }
}
