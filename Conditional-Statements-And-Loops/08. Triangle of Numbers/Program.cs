using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //get input
            int num = int.Parse(Console.ReadLine());

            for (int columnNum = 1; columnNum <= num; columnNum++)
            {
                for (int rowNum = 1; rowNum <= columnNum ; rowNum++)
                {
                    Console.Write(columnNum + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
