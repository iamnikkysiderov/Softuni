using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class ParkingLot
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var parkingLot = new HashSet<string>();

            while (input != "END")
            {
                var inputParams = input.Split(',');
                var command = inputParams[0].Trim();
                var carNumber = inputParams[1].Trim();

                if (command == "IN")
                {
                    parkingLot.Add(carNumber);
                }
                else
                {
                    parkingLot.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (parkingLot.Count > 0)
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
