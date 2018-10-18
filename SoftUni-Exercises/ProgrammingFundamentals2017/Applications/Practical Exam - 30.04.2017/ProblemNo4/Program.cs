using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProblemNo4
{
    class Team
    {
        public string Name { get; set; }

        public Dictionary<string, long> Members { get; set; }

        public double AverageScore()
        {
            return Members.Values.Average();
        }

        public double TotalScore()
        {
            return Members.Values.Sum();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            Regex regex = new Regex(@"[a-zA-Z0-9\s]*$");

            while (input != "quit")
            {
                List<string> collection = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (regex.IsMatch(collection[1].Trim()) == false || regex.IsMatch(collection[0].Trim()) == false)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string currentTeamName = collection[1].Trim();
                string currentMemberName = collection[0].Trim();
                long currentPowerOfMember = long.Parse(collection[2].Trim());

                if (teams.ContainsKey(currentTeamName))
                {
                    bool containedUser = false;

                    if (!teams[currentTeamName].Members.ContainsKey(currentMemberName))
                    {
                        foreach (var alreadyExistingTeam in teams)
                        {
                            Team existingTeam = alreadyExistingTeam.Value;

                            if (existingTeam.Members.ContainsKey(currentMemberName))
                            {
                                containedUser = true;
                                break;
                            }
                        }

                        if (containedUser == false)
                        {
                            teams[currentTeamName].Members[currentMemberName] = 0;
                        }
                    }

                    if (containedUser == false)
                    {
                        teams[currentTeamName].Members[currentMemberName] += currentPowerOfMember;
                    }
                }
                else
                {
                    Team team = new Team();
                    team.Name = currentTeamName;
                    team.Members = new Dictionary<string, long>();
                    bool containedUser = false;

                    foreach (var alreadyExistingTeam in teams)
                    {
                        Team existingTeam = alreadyExistingTeam.Value;

                        if (existingTeam.Members.ContainsKey(currentMemberName))
                        {
                            containedUser = true;
                            break;
                        }
                    }

                    if (containedUser == false)
                    {
                        if (!team.Members.ContainsKey(currentMemberName))
                        {
                            team.Members[currentMemberName] = 0;
                        }

                        team.Members[currentMemberName] += currentPowerOfMember;
                    }

                    teams[currentTeamName] = team;
                }

                input = Console.ReadLine();
            }

            long counter = 0;

            var sortedTeams = teams.OrderByDescending(x => x.Value.Members.Values.Sum()).ThenByDescending(x => x.Value.AverageScore());

            foreach (var team in sortedTeams)
            {
                string name = team.Value.Name;
                Dictionary<string, long> members = team.Value.Members;
                counter++;

                Console.WriteLine($"{counter}. Team: {name} - {team.Value.TotalScore()}");

                foreach (var member in members.OrderByDescending(x => x.Value))
                {
                    string memberName = member.Key;
                    long memberScore = member.Value;

                    Console.WriteLine($"###{memberName} : {memberScore}");
                }
            }
        }
        public static bool IsAlphaNumeric(string strToCheck)
        {
            return strToCheck.All(char.IsLetterOrDigit);
        }
    }
}
