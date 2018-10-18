using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ResizableArray
{
    class ResizableArray
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>();
            List<string> command = Console.ReadLine().Split(' ').ToList();

            while (command[0] != "end")
            {
                if (command[0] == "push")
                {
                    if (array.Count == 0)
                    {
                        array.Add(int.Parse(command[1]));
                    }
                    else
                    {
                        array.Add(int.Parse(command[1]));
                    }
                }
                else if (command[0] == "pop")
                {
                    array.RemoveAt(array.Count - 1);
                }
                else if (command[0] == "removeAt")
                {
                    array.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "clear")
                {
                    array = new List<int>();
                }

                command = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
