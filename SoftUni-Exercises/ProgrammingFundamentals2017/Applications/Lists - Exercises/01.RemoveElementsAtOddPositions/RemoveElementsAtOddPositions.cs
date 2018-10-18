using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveElementsAtOddPositions
{
    class RemoveElementsAtOddPositions
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
