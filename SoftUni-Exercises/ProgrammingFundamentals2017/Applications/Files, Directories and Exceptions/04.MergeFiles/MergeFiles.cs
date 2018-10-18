using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.MergeFiles
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            List<string> firstFileItems = File.ReadAllText("input1.txt").Split('\n').ToList();
            List<string> secondFileItems = File.ReadAllText("input2.txt").Split('\n').ToList();
            List<string> mergedItems = new List<string>();

            for (int i = 0; i < firstFileItems.Count; i++)
            {
                mergedItems.Add(firstFileItems[i]);
                mergedItems.Add(secondFileItems[i]);
            }

            File.WriteAllLines("output.txt", mergedItems);
        }
    }
}
