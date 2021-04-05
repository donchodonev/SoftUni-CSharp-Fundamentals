using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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
                    isChanged = true;
                }

                else if (command[0] == "Remove")
                {
                    numList.Remove(int.Parse(command[1]));
                    isChanged = true;
                }

                else if (command[0] == "RemoveAt")
                {
                    numList.RemoveAt(int.Parse(command[1]));
                    isChanged = true;
                }

                else if (command[0] == "Insert")
                {
                    numList.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    isChanged = true;
                }

                else if (command[0] == "Contains")
                {
                    if (numList.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                else if (command[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(' ', numList.Where(n => n % 2 == 0)));
                }

                else if (command[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(' ', numList.Where(n => n % 2 == 0)));
                }

                else if (command[0] == "PrintOdd")
                {
                    Console.WriteLine(string.Join(' ', numList.Where(n => n % 2 != 0)));
                }

                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(numList.Sum());
                }

                else if (command[0] == "Filter")
                {
                    if (command[1] == ">")
                    {
                        Console.WriteLine(string.Join(' ', numList.Where(n => n > int.Parse(command[2]))));
                    }

                    else if (command[1] == "<")
                    {
                        Console.WriteLine(string.Join(' ', numList.Where(n => n < int.Parse(command[2]))));
                    }

                    else if (command[1] == ">=")
                    {
                        Console.WriteLine(string.Join(' ', numList.Where(n => n >= int.Parse(command[2]))));
                    }
                    else
                    {
                        Console.WriteLine(string.Join(' ', numList.Where(n => n <= int.Parse(command[2]))));
                    }
                }

                command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(' ', numList));
            }
        }
    }
}
