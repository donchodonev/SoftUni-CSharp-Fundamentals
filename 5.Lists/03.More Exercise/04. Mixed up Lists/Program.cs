using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                             .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToList();

            List<int> secondList = Console.ReadLine()
                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToList();

            //намираме по-малкия лист

            int smallerListCount = Math.Min(firstList.Count, secondList.Count); 

            //декларираме си нов лист, където ще слепим 2та инпут листа

            List<int> combinedList = new List<int>(smallerListCount);

            //обръщаме 2-рия лист, знаем, че ни трябват неговите елементи отзад-напред
            //по този начин въртим само 1 цикъл

            secondList.Reverse();

            for (int i = 0; i < smallerListCount; i++)
            {
                combinedList.Add(firstList[i]);
                combinedList.Add(secondList[i]);
            }

            int constraintOne = 0;
            int constraintTwo = 0;

            if (firstList.Count > secondList.Count)
            {
                constraintOne = firstList[firstList.Count - 1];
                constraintTwo = firstList[firstList.Count - 2];
            }
            else
            {
                constraintOne = secondList[secondList.Count - 1];
                constraintTwo = secondList[secondList.Count - 2];
            }

            //намираме по-голямото/по-малкото на последните 2 елемента,които ще ползваме за констрейнт

            int smallerConstraintNum = Math.Min(constraintTwo, constraintOne);
            int biggerConstraintNum = Math.Max(constraintTwo, constraintOne);

            List<int> listToPrint = new List<int>(20);

            //пълним си финалния масив само с елементи които влизат между 2-та констрейнта

            listToPrint = combinedList.Where(n => n > smallerConstraintNum && n < biggerConstraintNum).ToList();

            listToPrint.Sort();

            Console.WriteLine(string.Join(" ", listToPrint));
        }
    }
}
