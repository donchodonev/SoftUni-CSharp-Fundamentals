using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    class Cargo
    {
        public Cargo()
        {

        }
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public int Weight { get; set; }
        public string Type { get; set; }
    }
    class Engine
    {
        public Engine()
        {

        }
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Speed { get; set; }
        public int Power { get; set; }
    }
    class Car
    {
        public Car()
        {

        }
        public Car(Cargo cargo, Engine engine, string model)
        {
            Cargo = cargo;
            Engine = engine;
            Model = model;
        }

        public Cargo Cargo { get; set; } = new Cargo();
        public Engine Engine { get; set; } = new Engine();
        public string Model { get; set; }
        public override string ToString()
        {
            return $"{Model}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>(n);

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string carModel = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];

                Engine engine = new Engine(engineSpeed,enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                cars.Add(new Car(cargo, engine, carModel));
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars = cars.FindAll(x => x.Cargo.Type == "fragile" && x.Cargo.Weight < 1000);

                foreach (Car car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                cars = cars.FindAll(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250);

                foreach (Car car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
