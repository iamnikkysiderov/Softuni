using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _124.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dictionary<string, string> nameEmailPairs = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = Console.ReadLine();
                List<string> emailChecker = email.Split('.').ToList();

                if (emailChecker[emailChecker.Count-1].ToLower() != "uk")
                {
                    if (emailChecker[emailChecker.Count-1].ToLower() != "us")
                    {
                        nameEmailPairs[name] = email;
                    }
                }

                name = Console.ReadLine();
            }

            foreach (var key in nameEmailPairs.Keys)
            {
                Console.WriteLine($"{key} -> {nameEmailPairs[key]}");
            }
        }
    }
}
