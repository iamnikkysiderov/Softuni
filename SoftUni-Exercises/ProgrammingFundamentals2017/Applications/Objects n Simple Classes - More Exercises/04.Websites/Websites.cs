using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
    class Websites
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> websites = new List<string>();

            while (input != "end")
            {
                List<string> inputParams = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Website website = new Website();
                website.Host = inputParams[0];
                website.Domain = inputParams[1];
                website.Queries = new List<string>();

                if (inputParams.Count >= 3)
                {
                    inputParams.RemoveAt(0);
                    inputParams.RemoveAt(0);
                    inputParams = inputParams[0].Split(',').ToList();

                    for (int i = 0; i < inputParams.Count; i++)
                    {
                        if (i == inputParams.Count - 1)
                        {
                            string finalQuery = $"[{inputParams[i]}]";

                            website.Queries.Add(finalQuery);
                            break;
                        }

                        string query = $"[{inputParams[i]}]&";


                        website.Queries.Add(query);
                    }

                    websites.Add($"https://www.{website.Host}.{website.Domain}/query?={string.Join("", website.Queries)}");

                    input = Console.ReadLine();
                    continue;
                }

                websites.Add($"https://www.{website.Host}.{website.Domain}");

                input = Console.ReadLine();
            }

            for (int i = 0; i < websites.Count; i++)
            {
                Console.WriteLine(websites[i]);
            }
        }
    }
}
