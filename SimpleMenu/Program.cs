using System;

namespace SimpleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            char userChoice;

            Console.WriteLine("Please choose one of the following options");
            Console.WriteLine("1 - Cappucino");
            Console.WriteLine("2 - Latte");
            Console.WriteLine("3 - Americano");
            Console.WriteLine("4 - Mocha");
            Console.WriteLine("5 - Macchiatio");
            Console.WriteLine("6 - Espresso");
            Console.WriteLine("Q - Quit");

            //while (!userChoice.Equals('q'))
            //while (!(userChoice.Equals('q') || userChoice.Equals('Q')))
            do
            {
                userChoice = char.ToLower(Console.ReadKey(true).KeyChar);
                Console.WriteLine("You Chose " + userChoice);

                switch (userChoice)
                {
                    case '1':
                        Console.WriteLine("Making Cappucino...");
                        Console.WriteLine("Steam the milk");
                        Console.WriteLine("Froth the milk");
                        Console.WriteLine("Make espresso.");
                        Console.WriteLine("Add the milk to the espresso");
                        break;
                    case '2':
                        Console.WriteLine("Making Latte");
                        Console.WriteLine("Make expresso");
                        Console.WriteLine("Steam the milk");
                        Console.WriteLine("Add the milk to the espresso");
                       break;
                    case '3':
                        Console.WriteLine("Making Americano");
                        break;
                    case '4':
                        Console.WriteLine("Making Mocha");
                        break;
                    case '5':
                        Console.WriteLine("Making Macchiato");
                        break;
                    case '6':
                        Console.WriteLine("Making Espresso");
                        break;
                    default:
                        Console.WriteLine("Returning coins");
                        continue;
                }
                Console.WriteLine("Dispensing coffee");
                Console.WriteLine("Have a nice day");
            } while (!userChoice.Equals('q'));
        }
    }
}
