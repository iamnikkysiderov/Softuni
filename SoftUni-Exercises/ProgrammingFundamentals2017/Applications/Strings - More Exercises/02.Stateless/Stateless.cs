using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Stateless
{
    class Stateless
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "collapse")
            {
                string fiction = Console.ReadLine();
                bool textStillHasElements = true;


                while (true)
                {
                    int i = input.IndexOf(fiction);

                    if (fiction == string.Empty)
                    {
                        break;
                    }

                    if (i >= 0)
                    {
                        input = input.Remove(i, fiction.Length);

                        if (input.Length == 0)
                        {
                            textStillHasElements = false;
                            break;
                        }
                    }
                    else
                    {
                        try
                        {
                            fiction = fiction.Remove(0, 1);
                            fiction = fiction.Remove(fiction.Length - 1, 1);
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                }

                if (textStillHasElements)
                {
                    Console.WriteLine(input.Trim());
                }
                else
                {
                    Console.WriteLine("(void)");
                }

                input = Console.ReadLine();
            }
        }
    }
}
