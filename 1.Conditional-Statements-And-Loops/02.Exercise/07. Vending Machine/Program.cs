using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double coinSum = 0.0;
            bool continueCoinCollection = true;

            while (continueCoinCollection)
            {
                string coinCollection = Console.ReadLine();
                //check if input is start or a num
                if (coinCollection == "Start")
                {
                    continueCoinCollection = false;
                    break;
                }
                //check if num is a valid coin - 0.1/0.2/0.5/1/2
                double coin = double.Parse(coinCollection);

                switch (coin)
                {
                    case 0.1:
                        coinSum += coin;
                        break;
                    case 0.2:
                        coinSum += coin;
                        break;
                    case 0.5:
                        coinSum += coin;
                        break;
                    case 1:
                        coinSum += coin;
                        break;
                    case 2:
                        coinSum += coin;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }
            }
            //purchase loop logic

            bool customerIsPurchasing = true;

            while (customerIsPurchasing)
            {
                string productChoice = Console.ReadLine();

                //check for end of purchase
                if (productChoice == "End")
                {
                    Console.WriteLine($"Change: {coinSum:F2}");
                    customerIsPurchasing = false;
                    break;
                }

                if (productChoice == "Nuts") // Nuts price = 2.0
                {
                    if (2.0 <= coinSum)
                    {
                        coinSum -= 2.0;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (productChoice == "Water") // Water price = 0.7
                {
                    if (0.7 <= coinSum)
                    {
                        coinSum -= 0.7;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (productChoice == "Crisps") // Crisps price = 1.5
                {
                    if (1.5 <= coinSum)
                    {
                        coinSum -= 1.5;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (productChoice == "Soda") // Soda price = 0.8
                {
                    if (0.8 <= coinSum)
                    {
                        coinSum -= 0.8;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (productChoice == "Coke") // Coke price = 1.0
                {
                    if (1.0 <= coinSum)
                    {
                        coinSum -= 1.0;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
        }
    }
}
