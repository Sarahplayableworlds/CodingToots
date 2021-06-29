using System;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Car myCar = new Car("The Flying Purple Penguin");
            Car anotherCar = new Car("Batmobile");

            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Brake();
            myCar.Accelerate();

            anotherCar.Brake();
        }
    }

    class Car
    {
        private int speed = 0;
        private string name;

        public Car(string carName)
        {
            name = carName;
        }
        public void Accelerate()
        {
            speed++;
            Console.WriteLine($"{name} is going {speed} mph.");
        }

        public void Brake()
        {
            speed--;
            Console.WriteLine($"{name} is going {speed} mph.");
        }
    }
}
