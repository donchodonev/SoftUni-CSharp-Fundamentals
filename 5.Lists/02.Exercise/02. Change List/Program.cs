using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> listCol = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            while (input[0] != "end")
            {
                switch (input[0])
                {
                    case "Delete":
                        listCol = DeleteElement(int.Parse(input[1]), listCol);
                        break;
                    case "Insert":
                        listCol = InsertElement(int.Parse(input[1]), int.Parse(input[2]), listCol);
                        break;
                }

                input = Console.ReadLine()
                .Split()
                .ToArray();
            }

            Console.WriteLine(string.Join(' ', listCol));
        }

        static List<int> DeleteElement(int element, List<int> listCollection)
        {
            listCollection.RemoveAll(n => n == element);

            return listCollection;
        }

        static List<int> InsertElement(int element, int index, List<int> listCollection)
        {
            listCollection.Insert(index, element);

            return listCollection;
        }

    }
}
