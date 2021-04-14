using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{

    class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>(15);

            string[] input = Console.ReadLine().Split();

            while (input.Length > 1)
            {
                Person person = new Person (input[0], input[1], int.Parse(input[2]));
                people.Add(person);

                input = Console.ReadLine().Split();
            }

            people = people.OrderBy(x => x.Age).ToList();


            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }
    }
}
