using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> inputParams = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string text = inputParams[0].TrimEnd();
                List<string> items = inputParams[1].TrimStart().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < items.Count; i++)
                {
                    text = text.Replace($"{{{i}}}", items[i]);
                }

                Console.WriteLine(text);

                input = Console.ReadLine();
            }
        }
    }
}
