using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            using (StreamReader streamReader = new StreamReader("..//resources//text.txt"))
            {
                var line = streamReader.ReadLine();
                int counter = 0;

                while (line != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    counter++;

                    line = streamReader.ReadLine();
                }
            }
        }
    }
}
