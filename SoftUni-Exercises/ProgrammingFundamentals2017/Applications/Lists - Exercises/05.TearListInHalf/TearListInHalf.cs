using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TearListInHalf
{
    class TearListInHalf
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            List<string> HalfToTear = new List<string>();
            List<string> secondHalf = new List<string>();

            List<string> result = new List<string>();

            for (int i = 0; i < input.Count / 2; i++)
            {
                secondHalf.Add(input[i]);
            }

            for (int i = input.Count / 2; i < input.Count; i++)
            {
                HalfToTear.Add(input[i]);
            }

            for (int i = 0; i < HalfToTear.Count; i++)
            {
                string number = HalfToTear[i];

                for (int j = 0; j < number.Length; j += 2)
                {
                    result.Add(number[j].ToString());
                    result.Add(secondHalf[i]);
                    result.Add(number[j + 1].ToString());

                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
