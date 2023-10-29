using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Engine
    {
        public double Displacement { get; set; }
        public double FuelAmount { get; set; }
        private double TankCapacity { get; set; }
        private double DefaultTankCapacity { get; set; } = 50.0;

        public Engine(double Displacement, double FuelAmount)
        {
            this.Displacement = Displacement;
            this.FuelAmount = FuelAmount;
            this.DefaultTankCapacity = TankCapacity;
        }
        public Engine(double Displacement, double fuelAmount, double TankCapacity) 
        {
            this.Displacement = Displacement;
            this.TankCapacity = TankCapacity;
            this.TankCapacity = TankCapacity;
            
        }
        public double LitersToMPG(double litersPer100kms) 
        {
            const double litersToGallons = 0.264172;
            const double kmToMiles = 0.621371;
            return (100 * litersToGallons) / (litersPer100kms * kmToMiles);

        }
        public double MPGToLiters(double mpg)
        {
            const double litersToGallons = 0.264172;
            const double kmToMiles = 0.621371;
            return (100 * litersToGallons) / (mpg * kmToMiles);
        }

        public void Work(double distance)
        {
            FuelAmount -= 4 * Displacement * (distance / 100);
        }

        public void Refuel(double amount)
        {
            if (FuelAmount + amount <= TankCapacity)
            {
                FuelAmount += amount;
            }
            else
            {
                Console.WriteLine("You're trying to add more fuel than the tank can hold.");
            }
        }
    }
};
