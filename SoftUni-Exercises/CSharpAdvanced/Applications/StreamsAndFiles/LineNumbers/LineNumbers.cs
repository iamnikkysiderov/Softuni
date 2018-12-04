using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            using (StreamReader streamReader = new StreamReader("..//resources//text.txt"))
            {
                var line = streamReader.ReadLine();

                using (StreamWriter streamWriter = new StreamWriter("..//resources//my-edited-text.txt"))
                {
                    int counter = 1;

                    while (line != null)
                    {
                        streamWriter.WriteLine($"Line {counter++}: {line}");

                        line = streamReader.ReadLine();
                    }
                }
            }
        }
    }
}
