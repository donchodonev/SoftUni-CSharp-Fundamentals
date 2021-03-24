using System;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int endRangeNum = int.Parse(Console.ReadLine());

            for (int primeNum = 2; primeNum <= endRangeNum; primeNum++)
            {
                bool isPrime = true;

                for (int devisor = 2; devisor < primeNum; devisor++)
                {
                    if (primeNum % devisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", primeNum, isPrime.ToString().ToLower());
            }
        }
    }
}
