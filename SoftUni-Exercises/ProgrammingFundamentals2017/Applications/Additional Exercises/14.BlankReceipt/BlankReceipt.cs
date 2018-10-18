using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BlankReceipt
{
    class BlankReceipt
    {
        static void Main(string[] args)
        {
            Header();
            Body();
            Footer();
        }

        static void Header()
        {
            Console.WriteLine(@"CASH RECEIPT
------------------------------");
        }
        static void Body()
        {
            Console.WriteLine(@"Charged to____________________
Received by___________________");
        }
        static void Footer()
        {
            char unicode = '\u00A9';
            Console.WriteLine(@"------------------------------
{0} SoftUni",unicode);
        }
    }
}
