using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Department
    {
        public Department(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public double TotalSalaries { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public void AddEmployee(string name, double salary)
        {
            TotalSalaries += salary;
            Employees.Add(new Employee(name, salary));
        }

    }
    class Employee
    {
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public double Salary { get; set; }


    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Department> departments = new List<Department>(n);

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();

                string name = inputArgs[0];
                double salary = double.Parse(inputArgs[1]);
                string department = inputArgs[2];

                if (!departments.Any(x => x.Name == department))
                {
                    departments.Add(new Department(department));
                }

                departments.Find(x => x.Name == department).AddEmployee(name, salary);
            }
            Department highestPaid = departments.OrderByDescending(x => x.TotalSalaries / x.Employees.Count()).First();

            Console.WriteLine($"Highest Average Salary: {highestPaid.Name}");

            foreach (Employee employee in highestPaid.Employees.OrderByDescending(emp => emp.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }
}
