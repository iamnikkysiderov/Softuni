using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SentenceSplit
{
    class SentenceSplit
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<string> textParams = text.Split(new string[] { Console.ReadLine() }, StringSplitOptions.None).ToList();

            Console.WriteLine("[" + string.Join(", ", textParams) + "]");
        }
    }
}
