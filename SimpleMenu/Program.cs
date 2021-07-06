﻿using System;

namespace SimpleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            char userChoice = ' ';

            Console.WriteLine("Please choose one of the following options");
            Console.WriteLine("1 - Cappucino");
            Console.WriteLine("2 - Latte");
            Console.WriteLine("3 - Americano");
            Console.WriteLine("4 - Mocha");
            Console.WriteLine("5 - Macchiatio");
            Console.WriteLine("6 - Espresso");
            Console.WriteLine("Q - Quit");

            //while (!userChoice.Equals('q'))
            while (!(userChoice.Equals('q') || userChoice.Equals('Q')))
            {
                userChoice = char.ToLower(Console.ReadKey(true).KeyChar);
                Console.WriteLine("You Chose " + userChoice);
            }

        }
    }
}
