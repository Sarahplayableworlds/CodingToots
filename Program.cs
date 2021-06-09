using System;

namespace StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string apples = "Apples";
            int appleQuantity = 8;
            int applePrice = 100;
            string oranges = "Oranges";
            int orangeQuantity = 12;
            int orangePrice = 80;

            string column1Heading = "Fruit";
            string column2Heading = "Quanity";
            string column3Heading = "Price";

            Console.WriteLine($"{column1Heading} {column2Heading} {column3Heading}");
            Console.WriteLine($"{apples} {appleQuantity} {applePrice} cents");
            Console.WriteLine($"{oranges} {orangeQuantity} {orangePrice} cents");
        }
    }
}
