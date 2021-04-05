using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isChanged = false;

            List<int> numList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            while (command[0] != "end")
            {

                if (command[0] == "Add")
                {
                    numList.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    numList.Remove(int.Parse(command[1]));
                }
                else if (command[0] == "RemoveAt")
                {
                    numList.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    numList.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }

                command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            Console.WriteLine(string.Join(' ', numList));
        }
    }
}
