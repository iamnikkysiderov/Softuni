using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MentorGroup
{
    class MentorGroup
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<DateTime>> personAttendanceStorage = new Dictionary<string, List<DateTime>>();
            Dictionary<string, List<string>> personCommentsStorage = new Dictionary<string, List<string>>();

            personAttendanceStorage = GetAttendingDatesForEachPerson(personAttendanceStorage);

            personCommentsStorage = GetCommentsForEachPerson(personCommentsStorage);

            PrintReport(personAttendanceStorage, personCommentsStorage);
        }
        static Dictionary<string, List<DateTime>> GetAttendingDatesForEachPerson(Dictionary<string, List<DateTime>> personAttendaceStorage)
        {
            string input = Console.ReadLine();

            while (input != "end of dates")
            {
                List<string> inputParams = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string personName = inputParams[0];
                List<DateTime> personsAttendance = new List<DateTime>();

                for (int i = 1; i <= inputParams.Count - 1; i++)
                {
                    personsAttendance.Add(DateTime.ParseExact(inputParams[i], "dd/MM/yyyy", null));
                }

                if (!personAttendaceStorage.ContainsKey(personName))
                {
                    personAttendaceStorage[personName] = new List<DateTime>();
                }

                personAttendaceStorage[personName].AddRange(personsAttendance);

                input = Console.ReadLine();
            }

            return personAttendaceStorage;
        }
        static Dictionary<string, List<string>> GetCommentsForEachPerson(Dictionary<string, List<string>> personCommentsStorage)
        {
            string input = Console.ReadLine();

            while (input != "end of comments")
            {
                List<string> inputParams = input.Split('-').ToList();
                string personName = inputParams[0];
                string comment = inputParams[1];

                if (!personCommentsStorage.ContainsKey(personName))
                {
                    personCommentsStorage[personName] = new List<string>();
                }

                personCommentsStorage[personName].Add(comment);

                input = Console.ReadLine();
            }

            return personCommentsStorage;
        }
        static void PrintReport(Dictionary<string, List<DateTime>> personAttendaceStorage, Dictionary<string, List<string>>
            personCommentsStorage)
        {
            foreach (var person in personAttendaceStorage.OrderBy(x => x.Key))
            {
                string personName = person.Key;
                List<DateTime> personAttendance = person.Value;

                if (personAttendaceStorage.Count != 0)
                {
                    Console.WriteLine($"{personName}");
                    Console.WriteLine($"Comments:");

                    if (personCommentsStorage.ContainsKey(personName))
                    {
                        foreach (var comment in personCommentsStorage[personName])
                        {
                            Console.WriteLine($"- {comment}");
                        }
                    }

                    Console.WriteLine("Dates attended:");

                    foreach (var attendance in personAttendance.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {attendance:dd/MM/yyyy}");
                    }
                }
            }
        }
    }
}
