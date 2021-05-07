using System;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //find length between @ and | = name
            //find length between # and * = age


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int nameStartIndex = input.IndexOf('@') + 1;
                int nameEndIndex = input.IndexOf('|');
                int nameLength = nameEndIndex - nameStartIndex;

                string name = input.Substring(nameStartIndex, nameLength);

                int ageStartIndex = input.IndexOf('#') + 1;
                int ageEndIndex = input.IndexOf('*');
                int ageLength = ageEndIndex - ageStartIndex;

                string age = input.Substring(ageStartIndex, ageLength);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
