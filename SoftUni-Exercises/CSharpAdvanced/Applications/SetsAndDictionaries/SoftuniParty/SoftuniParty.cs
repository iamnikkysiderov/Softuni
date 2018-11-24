using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniParty
{
    class SoftuniParty
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var reservationList = new List<string>();

            while (input != "PARTY")
            {
                reservationList.Add(input);
            }

            reservationList = reservationList
            while (input != "END")
            {
                if (reservationList.Contains(input))
                {
                    reservationList.Remove(input);
                }
            }

            Console.WriteLine(reservationList.Count);

            foreach (var reservation in reservationList)
            {
                Console.WriteLine(reservation);
            }
        }
    }
}
