using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            PrintCalculations(firstNum, secondNum, oper);
        }

        static void PrintCalculations(int firstNum, int secondNum, string oper)
        {
            switch (oper)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, firstNum + secondNum);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, firstNum - secondNum);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, firstNum * secondNum);
                    break;
                case "/":
                    Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, firstNum / secondNum);
                    break;
            }
        }
    }
}
