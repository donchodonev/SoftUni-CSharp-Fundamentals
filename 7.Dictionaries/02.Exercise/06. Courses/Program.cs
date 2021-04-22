using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine()
                     .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

            while (input.Length > 1)
            {
                string courseName = input[0];
                string studentName = input[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string> { studentName });
                }

                input = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }

            courses = courses.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var students in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {students}");
                };
            }
        }
    }
}
