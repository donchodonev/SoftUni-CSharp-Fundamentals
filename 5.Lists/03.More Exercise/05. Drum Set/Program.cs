using System;
using System.Collections.Generic;
using System.Linq;


namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> initialSet = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> currentSet = new List<int>(6);

            foreach (var item in initialSet)
            {
                currentSet.Add(item);
            }

            string input = Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                int power = int.Parse(input);

                List<int> indexOfBrokenDrum = new List<int>(6);

                for (int i = 0; i < currentSet.Count; i++)
                {
                    currentSet[i] -= power;

                    if (currentSet[i] <= 0)
                    {
                        indexOfBrokenDrum.Add(i);
                        currentSet.RemoveAt(i);
                    }

                    foreach (var index in indexOfBrokenDrum)
                    {
                        if (initialSet[index] * 3 <= savings)
                        {
                            savings -= initialSet[index] * 3;
                            currentSet.Insert(index, initialSet[index]);
                            indexOfBrokenDrum.RemoveAt(indexOfBrokenDrum.Count - 1);
                            break;
                        }
                        else
                        {
                            initialSet.RemoveAt(i);
                            indexOfBrokenDrum.RemoveAt(indexOfBrokenDrum.Count - 1);

                            if (i != currentSet.Count - 1)
                            {
                                i--;


                                break;
                            }
                        }
                    }

                    input = Console.ReadLine();
                }

                Console.WriteLine(string.Join(' ', currentSet));
                Console.WriteLine($"Gabsy has {savings:F2}lv.");
            }
        }
    }
}