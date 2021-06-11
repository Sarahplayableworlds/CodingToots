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

            Console.WriteLine($"int: minumum {int.MinValue}, maximum {int.MaxValue}");
            Console.WriteLine($"long: minumum {long.MinValue}, maximum {long.MaxValue}");

            Console.WriteLine($"float: minimum {float.MinValue}, maximum {float.MaxValue}");
            Console.WriteLine($"double: minimum {double.MinValue}, maximum {double.MaxValue}");
        }
    }
}
