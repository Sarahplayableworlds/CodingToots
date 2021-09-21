using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 12 * 3 / 4;
            double b = (12 * 3) / 4;
            double c = 12 * (3 / 4);
            Console.WriteLine($"{a}, {b}, {c},");
            Console.WriteLine();

            double d = 12.0 / 3.0 / 4.0;
            double e = (12.0 / 3.0) / 4.0;
            double f = 12.0 / (3.0 / 4.0);
            Console.WriteLine($"{d}, {e}, {f}");
            Console.WriteLine();

            int x = 12 + 3 - 4;
            int y = (12 + 3) - 4;
            int z = 12 + (3 - 4);
            Console.WriteLine($"{x}, {y}, {z}");
        }
    }
}
