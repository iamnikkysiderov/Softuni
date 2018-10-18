using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DecodeRadioFrequencies
{
    class DecodeRadioFrequencies
    {
        static void Main(string[] args)
        {
            List<string> numbersToConvert = Console.ReadLine().Split(' ').ToList();
            List<char> result = new List<char>();
            int indexWest = 0;
            int indexEast = 0;

            for (int i = 0; i < numbersToConvert.Count; i++)
            {
                string currentNumber = numbersToConvert[i];
                string westSide = string.Empty;
                string eastSide = string.Empty;
                bool east = false;

                for (int j = 0; j < currentNumber.Length; j++)
                {
                    if (currentNumber[j] == '.')
                    {
                        east = true;
                    }
                    else if (east == true)
                    {
                        eastSide += currentNumber[j];
                    }
                    else if (currentNumber[j] != '.' || east == false)
                    {
                        westSide += currentNumber[j];
                    }

                }


                if (int.Parse(westSide) != 0)
                {
                    result.Insert(indexWest, (char)int.Parse(westSide));
                    indexWest++;
                }

                if (int.Parse(eastSide) != 0)
                {
                    result.Reverse();
                    result.Insert(indexEast, (char)int.Parse(eastSide));
                    result.Reverse();
                    indexEast++;
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
