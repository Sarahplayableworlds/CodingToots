using System;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Car myCar = new Car();
            Car anotherCar = new Car();

            myCar.Accelerate();
            anotherCar.Brake();
        }
    }

    class Car
    {
        public void Accelerate()
        {
            Console.WriteLine("You're going faster.");
        }

        public void Brake()
        {
            Console.WriteLine("You're going slower.");
        }
    }
}
