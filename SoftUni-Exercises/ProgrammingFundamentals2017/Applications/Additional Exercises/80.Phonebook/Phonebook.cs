using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();
            string namesToFindNumbers = Console.ReadLine();

            while (namesToFindNumbers != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (namesToFindNumbers == names[i])
                    {
                        Console.WriteLine("{0} -> {1}",names[i],phoneNumbers[i]);
                    }
                }

                namesToFindNumbers = Console.ReadLine();
            }
        }
    }
}
