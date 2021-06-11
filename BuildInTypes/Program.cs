using System;

namespace BuildInTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"byte: Minimum {byte.MinValue}, maximum {byte.MaxValue}");
            //Console.WriteLine($"sbyte: Minimum {sbyte.MinValue}, maximum {sbyte.MaxValue}");
            //Console.WriteLine($"short: Minimum {short.MinValue}, maximum {short.MaxValue}");

            var x = 234;
            Console.WriteLine(x.GetType());

            Console.WriteLine($"int: minimum {int.MinValue}, maximum {int.MaxValue}");
            Console.WriteLine($"long: minimum {long.MinValue}, maximum {long.MaxValue}");

            Console.WriteLine();

            Console.WriteLine($"float: minimum {float.MinValue}, maximum {float.MaxValue}");
            Console.WriteLine($"double: minimum {double.MinValue}, maximum {double.MaxValue}");

            float f = 123.456789012345678f;
            double d = 123.456789012345678;
            Console.WriteLine($"f is {f:F99}");
            Console.WriteLine($"d is {d:F99}");

            var y = 123.4;
            Console.WriteLine(y.GetType());
        }
    }
}
