using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>(15); // create a new empty list with 15 slot capacity

            List<string> inputData = Console.ReadLine() //read input student data
                .Split()
                .ToList();

            while (inputData.Count > 1) // run a cycle until we receive the input "end"
            {
                string firstName = inputData[0];
                string lastName = inputData[1];
                int age = int.Parse(inputData[2]);
                string hometown = inputData[3];

                if (IsStudentExisting(students, firstName, lastName)) // check if we already have a student with such details
                {
                    Student student = GetStudent(students, firstName, lastName); //get the student

                    //overwrite that same existing student's data
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Hometown = hometown;
                    student.Age = age;
                }
                else //otherwise add the new student to the students' list using the input data
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = hometown,
                    };

                    students.Add(student);
                }

                inputData = Console.ReadLine() //get new data and repeat the cycle
                .Split()
                .ToList();
            }

            string hometownToPrintStudentFrom = Console.ReadLine(); // get the hometown to choose which students to print from the list

            //find the students by town

            List<Student> filteredList = students.Where(student => student.Hometown == hometownToPrintStudentFrom).ToList();

            //iterate through all the students in the filtered list and print
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

        static bool IsStudentExisting (List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent (List<Student> students, string firstName, string lastName)
        {

            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }
}
