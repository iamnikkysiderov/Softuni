using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            string[] allLines = File.ReadAllLines("input.txt");

            List<string> oddLines = new List<string>();

            for (int i = 1; i < allLines.Length; i+=2)
            {
                oddLines.Add(allLines[i]);
            }

            File.WriteAllLines("output.txt", oddLines);
        }
    }
}
