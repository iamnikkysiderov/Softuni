using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RoliTheCoder
{
    class Event
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public HashSet<string> Participants { get; set; }
    }

    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<int, Event> events = new Dictionary<int, Event>();

            while (input != "Time for Code")
            {
                List<string> inputParams = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                Event currentEvent = new Event();
                currentEvent.ID = int.Parse(inputParams[0]);

                if (inputParams[1][0] != '#')
                {
                    input = Console.ReadLine();
                    continue;
                }

                currentEvent.Name = inputParams[1].Remove(0, 1);
                currentEvent.Participants = new HashSet<string>();

                bool invalidParticipantInput = false;

                if (inputParams.Count > 2)
                {
                    for (int i = 2; i < inputParams.Count; i++)
                    {
                        if (inputParams[i][0] != '@')
                        {
                            invalidParticipantInput = true;
                            break;
                        }

                        currentEvent.Participants.Add(inputParams[i].Remove(0, 1));
                    }

                    if (invalidParticipantInput)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    if (events.ContainsKey(currentEvent.ID))
                    {
                        if (events[currentEvent.ID].Name == currentEvent.Name)
                        {
                            for (int i = 2; i < inputParams.Count; i++)
                            {
                                events[currentEvent.ID].Participants.Add(inputParams[i].Remove(0, 1));
                            }
                        }
                    }
                    else
                    {
                        events.Add(currentEvent.ID, currentEvent);
                    }
                }
                else
                {
                    events.Add(currentEvent.ID, currentEvent);
                }

                input = Console.ReadLine();
            }

            foreach (var item in events.OrderByDescending(x => x.Value.Participants.Count).ThenBy(x => x.Value.Name))
            {
                Event currentEvent = item.Value;

                Console.WriteLine($"{currentEvent.Name} - {currentEvent.Participants.Count}");

                if (currentEvent.Participants.Count > 0)
                {
                    foreach (var person in currentEvent.Participants.OrderBy(x => x))
                    {
                        Console.WriteLine($"@{person}");
                    }
                }
            }
        }
    }
}
