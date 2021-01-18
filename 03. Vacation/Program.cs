using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double peopleCount = double.Parse(Console.ReadLine());
            string peopleType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double pricePerPerson = 0;
            double discount = 0;
            double grandTotal = 0;



            // price calculation per person depending on person type and the day of the week
            if (dayOfWeek == "Friday")
            {
                switch (peopleType)
                {
                    case "Students":
                        pricePerPerson = 8.45;
                        break;
                    case "Business":
                        pricePerPerson = 10.90;
                        break;
                    case "Regular":
                        pricePerPerson = 15.00;
                        break;
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                switch (peopleType)
                {
                    case "Students":
                        pricePerPerson = 9.80;
                        break;
                    case "Business":
                        pricePerPerson = 15.60;
                        break;
                    case "Regular":
                        pricePerPerson = 20.00;
                        break;
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                switch (peopleType)
                {
                    case "Students":
                        pricePerPerson = 10.46;
                        break;
                    case "Business":
                        pricePerPerson = 16.00;
                        break;
                    case "Regular":
                        pricePerPerson = 22.50;
                        break;
                }
            }

            //discount calculation based on amount of people in a group type

            if (peopleType != "Business")
            {
                if (peopleType == "Students" && peopleCount >= 30)
                {
                    discount = 15;
                }
                if (peopleType == "Regular" && peopleCount >= 10 && peopleCount <= 20)
                {
                    discount = 5;
                }
                grandTotal = (pricePerPerson * peopleCount) - (((pricePerPerson * peopleCount) / 100) * discount);
            }
            else
            {
                if (peopleCount >= 100)
                {
                    discount = 10 * pricePerPerson;
                }
                grandTotal = (peopleCount * pricePerPerson) - discount;
            }
            Console.WriteLine($"Total price: {grandTotal:F2}");
        }
    }
}
