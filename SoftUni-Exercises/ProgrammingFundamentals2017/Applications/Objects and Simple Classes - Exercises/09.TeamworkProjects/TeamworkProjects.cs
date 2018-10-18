using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> teams = new Dictionary<string, List<string>>();

            teams = CreateTeams(teams);

            teams = JoinTeam(teams);

            Print(teams);
        }
        static Dictionary<string, List<string>> CreateTeams(Dictionary<string, List<string>> teams)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> creators = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> inputParams = Console.ReadLine().Split('-').ToList();
                string creator = inputParams[0];
                string teamName = inputParams[1];

                if (!(teams.ContainsKey(teamName) || creators.Contains(creator)))
                {
                    teams[teamName] = new List<string>();
                    teams[teamName].Add(creator);
                    Console.WriteLine("Team {0} has been created by {1}!", teamName, creator);
                    creators.Add(creator);

                    continue;
                }

                if (teams.ContainsKey(teamName))
                {
                    Console.WriteLine("Team {0} was already created!", teamName);
                }

                if (creators.Contains(creator))
                {
                    Console.WriteLine("{0} cannot create another team!", creator);
                }
            }

            return teams;
        }
        static Dictionary<string, List<string>> JoinTeam(Dictionary<string, List<string>> teams)
        {
            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                List<string> inputParams = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string username = inputParams[0];
                string teamToJoin = inputParams[1];

                bool userAlreadyHasTeam = false;

                if (teams.ContainsKey(teamToJoin))
                {
                    foreach (var team in teams.Values)
                    {
                        if (team.Contains(username))
                        {
                            Console.WriteLine("Member {0} cannot join team {1}!", username, teamToJoin);
                            userAlreadyHasTeam = true;
                            break;
                        }
                    }

                    if (userAlreadyHasTeam == false)
                    {
                        teams[teamToJoin].Add(username);
                    }
                }
                else
                {
                    Console.WriteLine("Team {0} does not exist!", teamToJoin);
                }

                input = Console.ReadLine();
            }

            return teams;
        }
        static void Print(Dictionary<string, List<string>> teams)
        {
            Dictionary<string, List<string>> disbandedTeams = new Dictionary<string, List<string>>();

            foreach (var kvp in teams.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                string currentTeam = kvp.Key;
                List<string> membersOfCurrentTeam = kvp.Value;
                string creator = membersOfCurrentTeam[0];
                membersOfCurrentTeam.Sort();

                if (membersOfCurrentTeam.Count == 1)
                {
                    disbandedTeams[currentTeam] = new List<string>();
                    disbandedTeams[currentTeam].AddRange(membersOfCurrentTeam);
                    teams.Remove(currentTeam);
                }
                else
                {
                    Console.WriteLine($"{currentTeam}");
                    Console.WriteLine($"- {creator}");

                    for (int i = 0; i < membersOfCurrentTeam.Count; i++)
                    {
                        if (membersOfCurrentTeam[i] != creator)
                        {
                            Console.WriteLine($"-- {membersOfCurrentTeam[i]}");
                        }
                    }
                }

            }

            Console.WriteLine("Teams to disband:");

            foreach (var item in disbandedTeams.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                string team = item.Key;

                Console.WriteLine($"{team}");
            }
        }
    }
}
