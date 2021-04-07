using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compare the cards from the first deck to the cards from the second deck

            //The player, who has the bigger card, takes both cards and puts them at the back of his hand 

            //the second player’s card is last, and the first person’s card (the winning one) is before it (second to last)

            //and the player with the smaller card must remove the card from his deck

            //If both players’ cards have the same values - no one wins, and the two compared cards must be removed from the decks

            //The game is over, when one of the decks is left without any cards. 

            //You have to print the winner on the console and the sum of the left cards: "{First/Second} player wins! Sum: {sum}".

            List<int> pOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> pTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            while (pOne.Count > 0  && pTwo.Count > 0)
            {
                int pOne0IndexNum = pOne[0];
                int pTwo0IndexNum = pTwo[0];


                if (pOne[0] > pTwo[0])
                {
                    pOne.RemoveAt(0);
                    pTwo.RemoveAt(0);

                    pOne.Add(pOne0IndexNum);
                    pOne.Add(pTwo0IndexNum);
                    continue;
                }

                else if (pTwo[0] > pOne[0])
                {
                    pOne.RemoveAt(0);
                    pTwo.RemoveAt(0);

                    pTwo.Add(pTwo0IndexNum);
                    pTwo.Add(pOne0IndexNum);
                    continue;
                }

                else
                {
                    pOne.RemoveAt(0);
                    pTwo.RemoveAt(0);
                }
            }

            if (pOne.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {pTwo.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {pOne.Sum()}");
            }
        }
    }
}
