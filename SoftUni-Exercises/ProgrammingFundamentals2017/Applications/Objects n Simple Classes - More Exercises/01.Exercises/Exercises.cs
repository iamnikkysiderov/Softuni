using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    class Exercises
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>> topics = new Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>();

            while (input != "go go go")
            {
                List<string> inputParams = input.Split(new[] { '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string topic = inputParams[0].Trim();
                string course = inputParams[1].Trim();
                string link = inputParams[2].Trim();
                List<string> problems = new List<string>();

                for (int i = 3; i < inputParams.Count; i++)
                {
                    problems.Add(inputParams[i].Trim());
                }
                
                if (!topics.ContainsKey(topic))
                {
                    topics[topic] = new Dictionary<string, Dictionary<string, List<string>>>();
                }
                if (!topics[topic].ContainsKey(course))
                {
                    topics[topic][course] = new Dictionary<string, List<string>>();
                }
                if (!topics[topic][course].ContainsKey(link))
                {
                    topics[topic][course][link] = new List<string>();
                }

                topics[topic][course][link].AddRange(problems);

                input = Console.ReadLine();
            }

            foreach (var kvp in topics)
            {
                string currentTopic = kvp.Key;
                Dictionary<string, Dictionary<string, List<string>>> innerDict = kvp.Value;

                Console.WriteLine($"Exercises: {currentTopic}");

                foreach (var item in innerDict)
                {
                    string currentCourse = item.Key;
                    Dictionary<string, List<string>> innerInnerDict = item.Value;

                    Console.WriteLine($"Problems for exercises and homework for the \"{currentCourse}\" course @ SoftUni.");

                    foreach (var thing in innerInnerDict)
                    {
                        string currentLink = thing.Key;
                        List<string> currentProblems = thing.Value;

                        Console.WriteLine($"Check your solutions here: {currentLink}");

                        for (int i = 0; i < currentProblems.Count; i++)
                        {
                            Console.WriteLine($"{i+1}. {currentProblems[i]}");
                        }
                    }
                }
            }
        }
    }
}
