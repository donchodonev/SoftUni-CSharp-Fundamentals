using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>(15);

            List<string> inputData = Console.ReadLine()
                .Split()
                .ToList();

            while (inputData.Count > 1)
            {
                Student student = new Student();

                string firstName = inputData[0];
                string lastName = inputData[1];
                int age = int.Parse(inputData[2]);
                string hometown = inputData[3];

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.Hometown = hometown;

                students.Add(student);

                inputData = Console.ReadLine()
                .Split()
                .ToList();
            }

            string hometownToPrintStudentFrom = Console.ReadLine();

            List<Student> filteredList = students.Where(student => student.Hometown == hometownToPrintStudentFrom).ToList();

            foreach (Student stu in filteredList)
            {
                Console.WriteLine($"{stu.FirstName} {stu.LastName} is {stu.Age} years old.");
            }


        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }
        }

    }
}
