using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Car
    {
        public Car(string model, string color, int hp)
        {
            Model = model;
            Color = color;
            HP = hp;
            Type = "Car";
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }
        public string Type { get; set; }
    }

    class Truck
    {
        public Truck(string model, string color, int hp)
        {
            Model = model;
            Color = color;
            HP = hp;
            Type = "Truck";
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }
        public string Type { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>(50);
            List<Truck> trucks = new List<Truck>(50);

            string[] inputArgs = Console.ReadLine().Split();

            while (inputArgs.Length > 1)
            {
                string type = inputArgs[0];
                string model = inputArgs[1];
                string color = inputArgs[2];
                int hp = int.Parse(inputArgs[3]);

                if (type == "car")
                {
                    Car inputCar = new Car(model, color, hp);
                    cars.Add(inputCar);
                }
                else
                {
                    Truck inputTruck = new Truck(model, color, hp);
                    trucks.Add(inputTruck);
                }

                inputArgs = Console.ReadLine().Split();
            }

            string[] modelNameInfoRequest = Console.ReadLine().Split();

            while (modelNameInfoRequest.Length == 1)
            {
                string modelName = modelNameInfoRequest[0];


                foreach (Truck truck in trucks)
                {
                    if (truck.Model == modelName)
                    {
                        Console.WriteLine($"Type: {truck.Type}");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HP}");
                    }
                }

                foreach (Car car in cars)
                {
                    if (car.Model == modelName)
                    {
                        Console.WriteLine($"Type: {car.Type}");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HP}");
                    }
                }

                modelNameInfoRequest = Console.ReadLine().Split();
            }


            double totalCarHP = 0.0;

            double totalTruckHP = 0.0;

            if (cars.Count > 0)
            {
                foreach (Car item in cars)
                {
                    totalCarHP += item.HP;
                }
                double averageCarHp = totalCarHP / cars.Count;
                Console.WriteLine($"Cars have average horsepower of: {averageCarHp:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            if (trucks.Count > 0)
            {
                foreach (Truck item in trucks)
                {
                    totalTruckHP += item.HP;
                }
                double averageTruckHp = totalTruckHP / trucks.Count;
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
}
