using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Pyramidic
{
    class Pyramidic
    {
        static void Main(string[] args)
        {
            List<string> pyramids = new List<string>();

            int n = int.Parse(Console.ReadLine());
            List<string> lines = new List<string>();

            for (int i = 0; i < n; i++)
            {
                lines.Add(Console.ReadLine());
            }

            for (int i = 0; i < lines.Count; i++)
            {
                string currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    char currentChar = currentLine[j];
                    int layer = 1;
                    string currentPyramid = string.Empty;

                    for (int k = i; k < lines.Count; k++)
                    {
                        string currentLayer = new string(currentChar, layer);

                        if (lines[k].Contains(currentLayer))
                        {
                            currentPyramid += currentLayer + "\r\n";
                        }
                        else
                        {
                            break;
                        }

                        layer += 2;
                    }

                    pyramids.Add(currentPyramid.Trim());
                }

            }

            Console.WriteLine(pyramids.OrderByDescending(x => x.Length).First());
        }
    }
}
