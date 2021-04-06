using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    numberList.Add(int.Parse(command[1]));
                }

                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) < numberList.Count && int.Parse(command[1]) >= 0)
                    {
                        numberList.RemoveAt(int.Parse(command[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                else if (command[0] == "Shift" && command[1] == "left")
                {
                    numberList = ShiftLeft(int.Parse(command[2]), numberList);
                }

                else if (command[0] == "Shift" && command[1] == "right")
                {
                    numberList = ShiftRight(int.Parse(command[2]), numberList);
                }

                else if (command[0] == "Insert")
                {
                    numberList = Insert(int.Parse(command[1]), int.Parse(command[2]), numberList);
                }
                //print
                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(' ', numberList));

        }
        static List<int> ShiftLeft(int count, List<int> collection)
        {
            int firstNum = 0;

            for (int i = 0; i < count; i++)
            {
                firstNum = collection[0];
                collection.RemoveAt(0);
                collection.Add(firstNum);
            }
            return collection;
        }

        static List<int> ShiftRight(int count, List<int> collection)
        {
            int lastNum = 0;

            for (int i = 0; i < count; i++)
            {
                lastNum = collection[collection.Count - 1];
                collection.RemoveAt(collection.Count - 1);
                collection.Insert(0, lastNum);
            }
            return collection;
        }

        static List<int> Insert(int number, int index, List<int> collection)
        {
            if (index >= collection.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
                return collection;
            }
            else
            {
                collection.Insert(index, number);
                return collection;
            }
        }
    }
}
