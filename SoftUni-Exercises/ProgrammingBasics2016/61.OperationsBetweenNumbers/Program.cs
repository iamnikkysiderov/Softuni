using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());

            string evenOdd = "";

            if (n2 == 0 && oper == '/' || n2 == 0 && oper == '%')
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else
            {
                switch (oper)
                {
                    case '+':
                        if ((n1 + n2) % 2 == 0)
                        {
                            evenOdd = "even";
                        }
                        else
                        {
                            evenOdd = "odd";
                        }
                        Console.WriteLine("{0} + {1} = {2} - {3}", n1, n2, n1 + n2, evenOdd);
                        break;
                    case '-':
                        if ((n1 - n2) % 2 == 0)
                        {
                            evenOdd = "even";
                        }
                        else
                        {
                            evenOdd = "odd";
                        }
                        Console.WriteLine("{0} - {1} = {2} - {3}", n1, n2, n1 - n2, evenOdd);
                        break;
                    case '*':
                        if ((n1 * n2) % 2 == 0)
                        {
                            evenOdd = "even";
                        }
                        else
                        {
                            evenOdd = "odd";
                        }
                        Console.WriteLine("{0} * {1} = {2} - {3}", n1, n2, n1 * n2, evenOdd);
                        break;
                    case '/':
                        Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2);
                        break;
                    case '%':
                        Console.WriteLine("{0} % {1} = {2}", n1, n2, n1 % n2);
                        break;
                }
            }
        }
    }
}
