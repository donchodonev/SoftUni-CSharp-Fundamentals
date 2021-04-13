using System;
using System.Collections.Generic;
using System.Linq;


namespace _07._Vehicle_Catalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HP { get; set; }
    }

    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('/')
                .ToList();

            List<Car> cars = new List<Car>(10);

            List<Truck> trucks = new List<Truck>(10);

            while (input.Count > 1)
            {
                string type = input[0];
                string brand = input[1];
                string model = input[2];
                int hpOrWeight = int.Parse(input[3]);

                if (type == "Car")
                {
                    Car car = new Car();

                    car.Brand = brand;
                    car.Model = model;
                    car.HP = hpOrWeight;

                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();

                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = hpOrWeight;

                    trucks.Add(truck);
                }

                input = Console.ReadLine()
                .Split('/')
                .ToList();

            }

            if (cars.Count > 0)
            {
                List<Car> sortedCars = cars.OrderBy(x => x.Brand).ToList();

                Console.WriteLine("Cars:");

                foreach (Car car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HP}hp");
                }
            }

            if (trucks.Count > 0)
            {
                List<Truck> sortedTrucks = trucks.OrderBy(x => x.Brand).ToList();

                Console.WriteLine("Trucks:");

                foreach (Truck truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
         }
    }
}
