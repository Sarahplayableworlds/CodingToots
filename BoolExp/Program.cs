using System;

namespace BoolExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int apples = 18;
            int oranges = 9;
            decimal applePrice = 12.60m;
            decimal orangePrice = 4.50m;

            Console.WriteLine(apples == oranges);
            Console.WriteLine(apples != oranges);
            Console.WriteLine($"{apples} > {oranges} is {apples > oranges}");
            Console.WriteLine($"{apples} < {oranges} is {apples > oranges}");
            Console.WriteLine($"{apples} >= {oranges} is {apples > oranges}");
            Console.WriteLine($"{apples} <= {oranges} is {apples > oranges}");
            Console.WriteLine($"{apples} is int is {apples is int}");

            Console.WriteLine($"Reducing apple cost: {(apples > oranges) && (applePrice > orangePrice)}");

        }
    }
}
