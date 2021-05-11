using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _1._Winning_Ticket
{

    class Ticket
    {
        public Ticket(char symbol, int lengthOfMatch)
        {
            Symbol = symbol;
            LengthOfMatch += lengthOfMatch;
        }
        public char Symbol { get; set; }
        public int LengthOfMatch { get; set; }
        public bool isMatch { get; set; }
        public bool isJackpot { get; set; }
    }



    class Program
    {
        public static Ticket CheckMatch(Ticket ticket)
        {
            Ticket currentTicket = ticket;

            if (ticket.LengthOfMatch / 2 >= 6)
            {
                currentTicket.isMatch = true;
            }
            if (ticket.LengthOfMatch / 2 == 10)
            {
                currentTicket.isMatch = true;
                currentTicket.isJackpot = true;
            }

            return currentTicket; ;
        }

        static void Main(string[] args)
        {
            List<Ticket> allTickets = new List<Ticket>();

            string pattern = @"([\@#$^]{6,10})";

            string[] tickets = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in tickets)
            {
                string firstHalf = string.Empty;
                string secondHalf = string.Empty;

                //check length to see if ticket is valid

                if (ticket.Length == 20)
                {
                    firstHalf = ticket.Substring(0, 10);
                    secondHalf = ticket.Substring(10, 10);
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                Match fHalfCheck = Regex.Match(firstHalf, pattern);
                Match sHalfCheck = Regex.Match(secondHalf, pattern);

                Dictionary<char, Ticket> charCount = new Dictionary<char, Ticket>();

                foreach (var character in fHalfCheck.ToString())
                {
                    if (charCount.ContainsKey(character))
                    {
                        charCount[character].Symbol = character;
                        charCount[character].LengthOfMatch++;
                    }
                    else
                    {
                        charCount.Add(character, new Ticket(character, 1));
                    }
                }

                foreach (var character in sHalfCheck.ToString())
                {
                    if (charCount.ContainsKey(character))
                    {
                        charCount[character].Symbol = character;
                        charCount[character].LengthOfMatch++;
                    }
                    else
                    {
                        charCount.Add(character, new Ticket(character, 1));
                    }
                }

                if (charCount.Count > 0)
                {
                    charCount = charCount.OrderByDescending(x => x.Value.LengthOfMatch).ToDictionary(x => x.Key, y => y.Value);

                    Ticket winningTicket = charCount.ElementAt(0).Value;

                    winningTicket = CheckMatch(winningTicket);

                    if (winningTicket.isJackpot)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10{winningTicket.Symbol} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {winningTicket.LengthOfMatch / 2}{winningTicket.Symbol}");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
