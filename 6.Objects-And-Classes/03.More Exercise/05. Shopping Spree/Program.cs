using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    class Product
    {
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public Product()
        {

        }
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Person
    {
        public Person()
        {

        }
        public Person(string name, int budget)
        {
            Name = name;
            Budget = budget;
        }

        public string Name { get; set; }
        public int Budget { get; set; }
        public List<string> Products { get; set; } = new List<string>();

        public void Buy(string productName, int productPrice)
        {
            if (productPrice <= Budget)
            {
                Budget -= productPrice;
                Products.Add(productName);
                Console.WriteLine($"{Name} bought {productName}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {productName}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            List<Person> people = new List<Person>();

            string[] personArgs = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            //further split the input to get each individual's name and budget
            for (int i = 0; i < personArgs.Length; i++)
            {
                string personName = personArgs[i].Split('=')[0];
                int personBudget = int.Parse(personArgs[i].Split('=')[1]);

                people.Add(new Person(personName, personBudget));
            }

            //further split the input to get each product's name and price

            string[] productArgs = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < productArgs.Length; i++)
            {
                string productName = productArgs[i].Split('=', StringSplitOptions.RemoveEmptyEntries)[0];
                int productPrice = int.Parse(productArgs[i].Split('=', StringSplitOptions.RemoveEmptyEntries)[1]);

                products.Add(new Product(productName, productPrice));
            }

            //start taking commands

            string[] commandArgs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (commandArgs.Length > 1)
            {
                string personName = commandArgs[0];
                string productName = commandArgs[1];
                people.Find(x => x.Name == personName).Buy(productName, products.Find(x => x.Name == productName).Price);

                commandArgs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (Person person in people)
            {
                if (person.Products.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ",person.Products)}");
                }
            }
        }
    }
}
