﻿using System;
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
            //double result1 = 0.1 * 7m;
            //double Result2 = 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1;

            //Console.WriteLine($"1st result is {result1:R}");
            //Console.WriteLine($"2nd result is {result2:R}");

            //double difference = result1 - Result2;
            //Console.WriteLine($"The difference is {difference:R}");

            decimal result1 = 0.1m * 7m;
            decimal Result2 = 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m + 0.1m;

            Console.WriteLine($"1st result is {result1}");
            Console.WriteLine($"2nd result is {Result2}");

            decimal difference = result1 - Result2;
            Console.WriteLine($"The difference is {difference}");


        }
    }
}
