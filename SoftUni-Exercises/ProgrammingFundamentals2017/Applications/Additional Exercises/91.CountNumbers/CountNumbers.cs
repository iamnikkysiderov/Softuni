using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 1;
            numbers.Sort();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}",numbers[i-1], count);
                    count = 1;
                }
                
            }

            Console.WriteLine("{0} -> {1}",numbers[numbers.Count-1], count);
        }
    }
}
