using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NetherRealms
{
    class Demon
    {
        public string Name { get; set; }

        public double Health { get; set; }

        public double Damage { get; set; }
    }

    class NetherRealms
    {
        static void Main(string[] args)
        {
            List<string> demons = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim()).ToList();

            foreach (var item in demons.OrderBy(x => x))
            {
                Demon demon = new Demon();
                demon.Name = item;
                demon.Health = 0;
                demon.Damage = 0;

                int multiplication = 0;
                int division = 0;

                for (int i = 0; i < demon.Name.Length; i++)
                {
                    double value = 0;

                    if (demon.Name[i] >= 48 && demon.Name[i] <= 57)
                    {
                        string potentialNumber = string.Empty;

                        while ((demon.Name[i] >= 48 && demon.Name[i] <= 57) || demon.Name[i] == 46)
                        {
                            potentialNumber += demon.Name[i];
                            i++;

                            if (i >= demon.Name.Length)
                            {
                                break;
                            }
                        }

                        value = double.Parse(potentialNumber);

                        demon.Damage += value;

                        i--;
                    }
                    else
                    {
                        switch (demon.Name[i])
                        {
                            case '*':
                                multiplication++;
                                break;
                            case '/':
                                division++;
                                break;
                            case '+':
                                string potentialNumber = string.Empty;

                                i++;

                                if (i >= demon.Name.Length)
                                {
                                    break;
                                }

                                while ((demon.Name[i] >= 48 && demon.Name[i] <= 57) || demon.Name[i] == 46)
                                {
                                    potentialNumber += demon.Name[i];
                                    i++;

                                    if (i >= demon.Name.Length)
                                    {
                                        break;
                                    }
                                }

                                value = double.Parse(potentialNumber);

                                demon.Damage += value;

                                i--;
                                break;
                            case '-':
                                string potentialNegativeNumber = string.Empty;

                                i++;

                                if (i >= demon.Name.Length)
                                {
                                    break;
                                }

                                while ((demon.Name[i] >= 48 && demon.Name[i] <= 57) || demon.Name[i] == 46)
                                {
                                    potentialNegativeNumber += demon.Name[i];
                                    i++;

                                    if (i >= demon.Name.Length)
                                    {
                                        break;
                                    }
                                }

                                value = double.Parse(potentialNegativeNumber);

                                demon.Damage -= value;

                                i--;
                                break;
                            default:
                                demon.Health += demon.Name[i];
                                break;
                        }
                    }
                }

                for (int i = 0; i < multiplication; i++)
                {
                    demon.Damage *= 2;
                }

                for (int i = 0; i < division; i++)
                {
                    demon.Damage /= 2;
                }

                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }
    }
}
