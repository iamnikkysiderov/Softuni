using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftuniKaraoke
{
    class SoftuniKaraoke
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            List<string> allowedSongs = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            List<string> performance = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();

            Dictionary<string, HashSet<string>> personAwards = new Dictionary<string, HashSet<string>>();

            while (performance[0] != "dawn")
            {
                if (participants.Contains(performance[0])) // performance[0] == currentParticipant
                {
                    if (allowedSongs.Contains(performance[1])) // performance[1] == currentSong
                    {
                        if (!personAwards.ContainsKey(performance[0]))
                        {
                            personAwards[performance[0]] = new HashSet<string>();
                        }

                        personAwards[performance[0]].Add(performance[performance.Count - 1]); // performance[performance.Count-1] == currentAward
                    }
                }

                performance = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            }

            if (personAwards.Count > 0)
            {
                foreach (var person in personAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    string name = person.Key;
                    List<string> awards = person.Value.OrderBy(x => x).ToList();

                    Console.WriteLine($"{name}: {awards.Count} awards");

                    for (int i = 0; i < awards.Count; i++)
                    {
                        Console.WriteLine($"--{awards[i]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
