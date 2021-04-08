using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distanceToPokemon = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();


            int index = int.Parse(Console.ReadLine());

            int sumOfAllRemovedElements = 0;

            while (distanceToPokemon.Count != 0)
            {

                if (index < 0)
                {
                    int removedIndexValue = distanceToPokemon[0];

                    sumOfAllRemovedElements += removedIndexValue;

                    distanceToPokemon.RemoveAt(0);

                    int lastIndexValue = distanceToPokemon[distanceToPokemon.Count - 1];

                    distanceToPokemon.Insert(0,lastIndexValue);

                    distanceToPokemon = IncreaseOrDecreaseElementsWithoutIndex(removedIndexValue, distanceToPokemon);
                }
                else if (index > distanceToPokemon.Count - 1)
                {
                    int removedIndexValue = distanceToPokemon[distanceToPokemon.Count-1];

                    int firstIndexValue = distanceToPokemon[0];

                    sumOfAllRemovedElements += removedIndexValue;

                    distanceToPokemon.RemoveAt(distanceToPokemon.Count - 1);

                    distanceToPokemon.Add(firstIndexValue);

                    distanceToPokemon = IncreaseOrDecreaseElementsWithoutIndex(removedIndexValue, distanceToPokemon);
                }
                else
                {
                    sumOfAllRemovedElements += distanceToPokemon[index];

                    distanceToPokemon = IncreaseOrDecreaseElements(index, distanceToPokemon);
                }


                if (distanceToPokemon.Count == 0)
                {
                    Console.WriteLine(sumOfAllRemovedElements);
                    break;
                }

                index = int.Parse(Console.ReadLine());
            }

        }
        static List<int> IncreaseOrDecreaseElements(int numIndex, List<int> distancesToPokemon)
        {
            int indexNumValue = distancesToPokemon[numIndex]; //get value of removed num

            distancesToPokemon.RemoveAt(numIndex); //remove num from list

            //get indexes of numbers smaller or equal to the removed number

            List<int> smallerOrEqualToRemoved = new List<int>(15);

            for (int i = 0; i < distancesToPokemon.Count; i++)
            {
                if (distancesToPokemon[i] <= indexNumValue)
                {
                    smallerOrEqualToRemoved.Add(i);
                }
            }

            //get indexes of numbers greater than the removed number

            List<int> greaterToRemoved = new List<int>(15);

            for (int i = 0; i < distancesToPokemon.Count; i++)
            {
                if (distancesToPokemon[i] > indexNumValue)
                {
                    greaterToRemoved.Add(i);
                }
            }

            //iterate through the list and increase the values of all numbers smaller or equal than the removed one

            foreach (var item in smallerOrEqualToRemoved)
            {
                distancesToPokemon[item] += indexNumValue;
            }
            //iterate through the list and decrease the values of all numbers greater than the removed one

            foreach (var item in greaterToRemoved)
            {
                distancesToPokemon[item] -= indexNumValue;
            }
            return distancesToPokemon;

        }


        static List<int> IncreaseOrDecreaseElementsWithoutIndex(int numValue, List<int> distancesToPokemon)
        {
            int indexNumValue = numValue; //get value of removed num

            //get indexes of numbers smaller or equal to the removed number

            List<int> smallerOrEqualToRemoved = new List<int>(15);

            for (int i = 0; i < distancesToPokemon.Count; i++)
            {
                if (distancesToPokemon[i] <= indexNumValue)
                {
                    smallerOrEqualToRemoved.Add(i);
                }
            }

            //get indexes of numbers greater than the removed number

            List<int> greaterToRemoved = new List<int>(15);

            for (int i = 0; i < distancesToPokemon.Count; i++)
            {
                if (distancesToPokemon[i] > indexNumValue)
                {
                    greaterToRemoved.Add(i);
                }
            }

            //iterate through the list and increase the values of all numbers smaller or equal than the removed one

            foreach (var item in smallerOrEqualToRemoved)
            {
                distancesToPokemon[item] += indexNumValue;
            }
            //iterate through the list and decrease the values of all numbers greater than the removed one

            foreach (var item in greaterToRemoved)
            {
                distancesToPokemon[item] -= indexNumValue;
            }

            return distancesToPokemon;
        }
    }
}
