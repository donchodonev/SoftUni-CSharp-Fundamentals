using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double userBalance = double.Parse(Console.ReadLine());
            double totalExpenses = 0.00;
            bool isNotGameTime = true; 
            bool isOutofMoney = userBalance <= totalExpenses;

            while (isNotGameTime || isNotGameTime)
            {
                string inputCheck = Console.ReadLine();
                double gamePrice = 0.00;
                bool isGameFound = true;

                //assign price
                //check for invalid input

                switch (inputCheck)
                {
                    case "Game Time":
                        isNotGameTime = false;
                        break;
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        isGameFound = false;
                        break;
                }

                //print logic

                if (isGameFound && isNotGameTime && (gamePrice + totalExpenses) <= userBalance)
                {
                    totalExpenses += gamePrice;
                    Console.WriteLine($"Bought {inputCheck}");
                }
                else if (isGameFound && isNotGameTime && (gamePrice + totalExpenses) >= userBalance)
                {
                    Console.WriteLine("Too Expensive");
                }
            }

            //end print logic

            if (userBalance - totalExpenses > 0)
            {
                Console.WriteLine($"Total spent: ${totalExpenses:F2}. Remaining: ${userBalance - totalExpenses:F2} ");
            }
            else if (userBalance <= totalExpenses)
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}
