using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double pricePerLightsabre = double.Parse(Console.ReadLine());
            double pricePerRobe = double.Parse(Console.ReadLine());
            double pricePerBelt = double.Parse(Console.ReadLine());

            // I see no reason for overbuilding the equation into different variables but it can be refactored for better readability
            double totalPrice = (pricePerRobe * studentsCount) + (pricePerBelt * (studentsCount - (studentsCount/6))) + (pricePerLightsabre * (Math.Ceiling(studentsCount * 1.10)));

            if (totalPrice <= moneyAvailable)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - moneyAvailable:F2}lv more.");
            }
        }
    }
}
