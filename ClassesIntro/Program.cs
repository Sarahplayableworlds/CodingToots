using System;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Car myCar = new Car("The Flying Purple Penguin");
            Car anotherCar = new Car("The Batmobile");

            myCar.Accelerate(5);
            myCar.Accelerate(30);
            myCar.Brake(4);

            anotherCar.Brake(1);
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

        public void Accelerate(int amount)
        {
            speed += amount; // speed = speed + amount
            ShowSpeed();
        }

        public void Brake(int speedReduction)
        {
            speed -= speedReduction;
            ShowSpeed();
        }

        private void ShowSpeed()
        { 
            Console.WriteLine($"{name} is going {speed} mph.");
        }
    }
}
