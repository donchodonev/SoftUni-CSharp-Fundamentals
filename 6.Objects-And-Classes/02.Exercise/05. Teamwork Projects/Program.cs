using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public Team()
        {
            Members = new List<string>();
        }
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>(5);

            for (int i = 0; i < n; i++)
            {
                List<string> newTeam = Console.ReadLine().Split('-').ToList();
                Team teamInput = new Team();

                string teamCreator = newTeam[0];
                string teamName = newTeam[1];

                bool teamExists = teams.Exists(x => x.Name == teamName);
                bool creatorHasATeam = teams.Exists(x => x.Creator == teamCreator);

                if (teamExists)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (creatorHasATeam)
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                }
                else
                {
                    teamInput.Creator = teamCreator;
                    teamInput.Name = teamName;

                    teams.Add(teamInput);
                    Console.WriteLine($"Team {newTeam[1]} has been created by {newTeam[0]}!");
                }
            }

            List<string> users = Console.ReadLine().Split("->").ToList();

            while (users.Count == 2)
            {
                string userName = users[0];
                string teamName = users[1];

                bool teamExists = teams.Exists(x => x.Name == teamName);

                bool memberExists = teams.Exists(x => x.Members.Exists(x => x == userName) || x.Creator == userName);

                if (!teamExists)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (memberExists)
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                }
                else
                {
                    foreach (Team team in teams)
                    {
                        if (team.Name == teamName)
                        {
                            team.Members.Add(userName);
                            break;
                        }
                    }
                }

                users = Console.ReadLine().Split("->").ToList();
            }

            //do the sorting and then iterate through the list of teams anew

            teams = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();

            foreach (Team team2 in teams)
            {
                if (team2.Members.Count > 0)
                {
                    team2.Members.Sort();//sort members by name to fulfill final condition

                    Console.WriteLine($"{team2.Name}");
                    Console.WriteLine($"- {team2.Creator}");

                    foreach (var member in team2.Members)
                    {
                        Console.WriteLine($"-- {member}");
                    }

                }
            }

            Console.WriteLine($"Teams to disband:");

            foreach (var item in teams)
            {
                if (item.Members.Count == 0)
                {
                    Console.WriteLine($"{item.Name}");
                }
            }
        }
    }
}
