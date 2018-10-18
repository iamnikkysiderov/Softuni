using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string[] inputFileLines = File.ReadAllLines("input.txt");

            for (int i = 0; i < inputFileLines.Length; i++)
            {
                inputFileLines[i] = $"{i + 1}. {inputFileLines[i]}";
            }

            File.WriteAllLines("output.txt", inputFileLines);
        }
    }
}
