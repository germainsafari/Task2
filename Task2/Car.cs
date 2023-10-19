using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Car
    {
        {
        public string Make { get; set; }
        public string Model { get; set; }
        public Engine CarEngine { get; set; }

        public Car(string make, string model, double displacement, double fuelAmount, double tankCapacity)
        {
            Make = make;
            Model = model;
            CarEngine = new Engine(displacement, fuelAmount, tankCapacity);
        }

        public Car(string make, string model, double displacement, double fuelAmount) : this(make, model, displacement, fuelAmount, Engine.DefaultTankCapacity) { }

        public Car(string make, string model, Engine engine)
        {
            Make = make;
            Model = model;
            CarEngine = engine;
        }

        public void Go(double distance)
        {
            Console.WriteLine("I'm riding");
            Thread.Sleep((int)(distance * 100));
            CarEngine.Work(distance);
            Console.WriteLine("Here I am!");
        }

        public void Refuel(double amount)
        {
            CarEngine.Refuel(amount);
        }
    }

}
}
