using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKM)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKM = fuelConsumptionPerKM;
            TravelledDistance = 0.00;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKM { get; set; }
        public double TravelledDistance { get; set; }

        public Car Drive(double amountOfKM)
        {
            double neededLitres = amountOfKM * FuelConsumptionPerKM;

            if (FuelAmount >=  neededLitres)
            {
                FuelAmount -= neededLitres;
                TravelledDistance += amountOfKM;

            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

            return this;
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TravelledDistance}";
        }

    }
    class Program
    {
        static void Main(string[] args)
         {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = inputArgs[0];

                double fuelAmount = double.Parse(inputArgs[1]);

                double fuelConsPerKM = double.Parse(inputArgs[2]);

                cars.Add(new Car(model, fuelAmount, fuelConsPerKM));
            }

            string[] commandArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (commandArgs.Length != 1 )
            {
                string carModel = commandArgs[1];
                double amountOfKM = double.Parse(commandArgs[2]);

                cars.Find(car => car.Model == carModel).Drive(amountOfKM);

                commandArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
