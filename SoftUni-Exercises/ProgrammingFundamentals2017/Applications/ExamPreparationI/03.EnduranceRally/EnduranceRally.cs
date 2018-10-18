using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnduranceRally
{
    class Driver
    {
        public string Name { get; set; }

        public double Fuel { get; set; }

        public int FinalStop { get; set; }
    }

    class EnduranceRally
    {
        static void Main(string[] args)
        {
            List<string> driversInput = Console.ReadLine().Split(' ').ToList();
            List<double> track = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<int> checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < driversInput.Count; i++)
            {
                Driver driver = new Driver();
                driver.Name = driversInput[i];
                driver.Fuel = driver.Name[0];
                bool fuelExpired = false;

                for (int j = 0; j < track.Count; j++)
                {
                    double value = track[j];
                    bool checkpoint = false;

                    for (int k = 0; k < checkpoints.Count; k++)
                    {
                        if (checkpoints[k] == j)
                        {
                            checkpoint = true;
                        }
                    }

                    if (checkpoint)
                    {
                        driver.Fuel += value;
                    }
                    else
                    {
                        driver.Fuel -= value;
                    }

                    if (driver.Fuel <= 0)
                    {
                        fuelExpired = true;
                        driver.FinalStop = j;
                        break;
                    }
                }

                if (fuelExpired)
                {
                    Console.WriteLine($"{driver.Name} - reached {driver.FinalStop}");
                }
                else
                {
                    Console.WriteLine($"{driver.Name} - fuel left {driver.Fuel:f2}");
                }
            }
        }
    }
}
