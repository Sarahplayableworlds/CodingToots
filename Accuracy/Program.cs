using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accuracy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double result1 = 0.1 * 8;
            double Result2 = 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1;

            Console.WriteLine($"1st result is {result1}");
            Console.WriteLine($"2nd result is {Result2}");

            double difference = result1 - Result2;
            Console.WriteLine($"The difference is {difference}");
        }
    }
}
