// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Hello, World!");
static void Main(string[] args)
{
    Console.WriteLine("Enter car make:");
    var make = Console.ReadLine();

    Console.WriteLine("Enter car model:");
    var model = Console.ReadLine();

    Console.WriteLine("Enter engine displacement:");
    var displacement = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter fuel volume:");
    var fuelVolume = double.Parse(Console.ReadLine());

    Console.WriteLine("Do you want to specify a fuel tank capacity? (y/n)");
    var input = Console.ReadLine();
    Car myCar;

    if (input.ToLower() == "y")
    {
        Console.WriteLine("Enter fuel tank capacity:");
        var tankCapacity = double.Parse(Console.ReadLine());
        myCar = new Car(make, model, displacement, fuelVolume, tankCapacity);
    }
    else
    {
        myCar = new Car(make, model, displacement, fuelVolume);
    }

    while (true)
    {
        Console.WriteLine("Enter distance to drive or type 'refuel' to refuel your car:");
        var action = Console.ReadLine();

        if (action.ToLower() == "refuel")
        {
            Console.WriteLine("Enter amount of fuel to refuel:");
            var refuelAmount = double.Parse(Console.ReadLine());
            myCar.Refuel(refuelAmount);
        }
        else
        {
            var distance = double.Parse(action);
            myCar.Go(distance);
        }
    }
}
    }