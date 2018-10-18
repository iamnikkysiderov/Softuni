using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            numbers.Reverse();

            Console.WriteLine(string.Join(" ",numbers.Take(3)));
        }
    }
}
