using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84.ResizableArray // Nereshena
{
    class ResizableArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            string command = Console.ReadLine();
            int count = 0;
            int pushCount = 0;
            int[] secondArr = new int[arr.Length * 2];

            while (command != "end")
            {
                if (command.Contains("push"))
                {
                    pushCount++;
                    string fullNumberString = string.Empty;

                    for (int j = 5; j < command.Length; j++)
                    {
                        fullNumberString += command[j];
                    }

                    int fullNumber = int.Parse(fullNumberString);

                    for (int i = arr.Length - 1; i > 0; i--)
                    {
                        arr[i - 1] = arr[i];
                        count++;

                        if (pushCount == count)
                        {
                            break;
                        }
                    }
                    arr[arr.Length - 1] = fullNumber;


                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
