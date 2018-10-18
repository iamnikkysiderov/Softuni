using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BookLibraryModification
{
    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, DateTime> result = new Dictionary<string, DateTime>();

            for (int i = 0; i < n; i++)
            {
                List<string> inputParams = Console.ReadLine().Split(' ').ToList();
                string titleOfBook = inputParams[0];
                DateTime dateOfRelease = DateTime.ParseExact(inputParams[3], "dd.MM.yyyy", null);

                result[titleOfBook] = dateOfRelease;
            }

            string dateToPrintAfterIt = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateToPrintAfterIt, "dd.MM.yyyy", null);

            Dictionary<string, DateTime> copy = new Dictionary<string, DateTime>();

            foreach (var kvp in result)
            {
                if (kvp.Value > date)
                {
                    copy.Add(kvp.Key, kvp.Value);
                }
            }

            foreach (var kvp in copy.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:dd.MM.yyyy}");
            }
        }
    }
}
