using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int ageofPerson = int.Parse(Console.ReadLine());

            if (typeOfDay == "Weekday")
            {
                if (ageofPerson >= 0 && ageofPerson <= 18)
                {
                    Console.WriteLine("12$");
                }
                else if (ageofPerson > 18 && ageofPerson <= 64)
                {
                    Console.WriteLine("18$");
                }
                else if (ageofPerson > 64 && ageofPerson <= 122)
                {
                    Console.WriteLine("12$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (typeOfDay == "Weekend")
            {
                if (ageofPerson >= 0 && ageofPerson <= 18)
                {
                    Console.WriteLine("15$");
                }
                else if (ageofPerson > 18 && ageofPerson <= 64)
                {
                    Console.WriteLine("20$");
                }
                else if (ageofPerson > 64 && ageofPerson <= 122)
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (typeOfDay == "Holiday")
            {
                if (ageofPerson >= 0 && ageofPerson <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (ageofPerson > 18 && ageofPerson <= 64)
                {
                    Console.WriteLine("12$");
                }
                else if (ageofPerson > 64 && ageofPerson <= 122)
                {
                    Console.WriteLine("10$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
        }
    }
}
