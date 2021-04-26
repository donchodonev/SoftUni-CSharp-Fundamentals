using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, int> totalSkillPerPlayer = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "Season end")
            {
                if (input.Contains(" -> "))
                {
                    string[] inputArgs = input.Split(" -> ",StringSplitOptions.RemoveEmptyEntries);

                    string playerName = inputArgs[0];
                    string position = inputArgs[1];
                    int skill = int.Parse(inputArgs[2]);

                    if (players.ContainsKey(playerName))
                    {
                        if (players[playerName].ContainsKey(position))
                        {
                            if (players[playerName][position] < skill)
                            {
                                int skillOffset = skill - players[playerName][position];
                                players[playerName][position] = skill;

                                totalSkillPerPlayer[playerName] += skillOffset;
                            }
                        }
                        else
                        {
                            totalSkillPerPlayer[playerName] += skill;
                            players[playerName].Add(position, skill);
                        }
                    }
                    else
                    {
                        players.Add(playerName, new Dictionary<string, int> { { position, skill } });
                        totalSkillPerPlayer.Add(playerName, skill);
                    }
                }
                // pvp logic
                else
                {
                    string[] inputArgs = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);

                    string playerName = inputArgs[0];
                    string secondPlayerName = inputArgs[1];

                    bool areFighting = false;

                    //check if there's going to be a fight(only happens if players can play at least 1 same position)
                    if (players.ContainsKey(playerName) && players.ContainsKey(secondPlayerName))
                    {
                        foreach (var position in players[playerName].Keys)
                        {
                            if (players[secondPlayerName].ContainsKey(position))
                            {
                                areFighting = true;
                                break;
                            }
                        }
                    }

                    if (areFighting)
                    {
                        if (totalSkillPerPlayer[playerName] > totalSkillPerPlayer[secondPlayerName])
                        {
                            players.Remove(secondPlayerName);
                            totalSkillPerPlayer.Remove(secondPlayerName);
                        }
                        else if (totalSkillPerPlayer[playerName] < totalSkillPerPlayer[secondPlayerName])
                        {
                            players.Remove(playerName);
                            totalSkillPerPlayer.Remove(playerName);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in totalSkillPerPlayer
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {

                Console.WriteLine($"{player.Key}: {player.Value} skill");

                foreach (var positionAndSkill in players[player.Key]
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {positionAndSkill.Key} <::> {positionAndSkill.Value}");
                }
            }
        }
    }
}
