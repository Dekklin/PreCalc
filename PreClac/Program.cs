using System;

namespace PreClac
{
    class Program
    {
        static void Main(string[] args)
        {
            StartMenu();
        }
        static void StartMenu()
        {
            Console.WriteLine("Welcome to my high class calculator, what would you like to do?");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Division");
            Console.WriteLine("9. Quit");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                CalcAdd();
            }
            if (userInput == "2")
            {
                CalcSub();
            }
            if (userInput == "3")
            {
                CalcMulti();
            }
            if (userInput == "4")
            {
                CalcDiv();
            }
            if (userInput == "9")
            {
                Console.ReadKey();
            }
        }
        static void CalcMulti()
        {
            Console.WriteLine("What number would you like to multiply?");
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"How many times would you like to multiply {baseNumber} by?");
            int component = Convert.ToInt32(Console.ReadLine());
            int answer = baseNumber * component;
            Console.WriteLine(answer);
            StartMenu();
        }
        static void CalcSub()
        {
            Console.WriteLine("What number would you like to start with?");
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"What number would you like to subtract {baseNumber} by?");
            int component = Convert.ToInt32(Console.ReadLine());
            int answer = baseNumber - component;
            Console.WriteLine(answer);
            StartMenu();
        }
        static void CalcAdd()
        {
            Console.WriteLine("What number would you like to start with?");
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"What number would you like to add to {baseNumber}?");
            int multiplier = Convert.ToInt32(Console.ReadLine());
            int answer = baseNumber + multiplier;
            Console.WriteLine(answer);
            StartMenu();
        }
        static void CalcDiv()
        {
            Console.WriteLine("What number would you like to divide?");
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"How many times would you like to divide {baseNumber} by?");
            int multiplier = Convert.ToInt32(Console.ReadLine());
            int answer = baseNumber / multiplier;
            Console.WriteLine(answer);
            StartMenu();
        }

    }
}
