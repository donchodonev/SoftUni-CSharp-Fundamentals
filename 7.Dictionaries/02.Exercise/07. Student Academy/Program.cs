using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> studentAndGrades = new Dictionary<string, double>();

            List<string> inputAgrs = new List<string>();

            for (int i = 0; i < n*2; i++)
            {
                inputAgrs.Add(Console.ReadLine());
            }

            for (int v = 0; v < inputAgrs.Count; v += 2)
            {
                string studentName = inputAgrs[v];
                double studentGrade = double.Parse(inputAgrs[v + 1]);

                if (studentAndGrades.ContainsKey(studentName))
                {
                    studentAndGrades[studentName] = (studentAndGrades[studentName] + studentGrade) / 2;
                }
                else
                {
                    studentAndGrades.Add(studentName, studentGrade);
                }
            }

            Dictionary<string,double> filteredStudents = studentAndGrades
                .Where(x => x.Value >= 4.50)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key , x => x.Value);

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
}
