using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = int.Parse(Console.ReadLine());
            int[] rotatedArr = new int[arr.Length];

            if (index == arr.Length)
            {
                foreach (var item in arr)
                {
                    Console.Write($"{item} ");
                }
            }
            else
            {
                {
                    index = index % arr.Length;
                }

                int lastIndexCounter = 0;

                for (int i = 0; i < arr.Length; i++)
                {

                    if (i < arr.Length - index)
                    {
                        rotatedArr[i] = arr[i + index];
                        lastIndexCounter++;
                    }
                    else
                    {
                        for (int v = 0; v < index; v++, i++)
                        {
                            rotatedArr[i] = arr[v];
                        }
                    }
                }
                foreach (var item in rotatedArr)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
