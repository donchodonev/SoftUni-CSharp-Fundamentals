using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Family
    {
        public Family()
        {
        }
        public List<Person> FamilyMembers { get; set; } = new List<Person>();

        public void AddMember(Person familyMember) 
        {
            FamilyMembers.Add(familyMember);
        }
        public void GetOldestMember() 
        {
            Person oldestPerson = FamilyMembers.OrderByDescending(x => x.Age).First();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();

                string personName = inputArgs[0];
                int personAge = int.Parse(inputArgs[1]);

                family.AddMember(new Person(personName, personAge));
            }

            family.GetOldestMember();
        }
    }
}
