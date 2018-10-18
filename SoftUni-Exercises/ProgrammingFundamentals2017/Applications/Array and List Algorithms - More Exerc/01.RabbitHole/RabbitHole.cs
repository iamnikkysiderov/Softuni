using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RabbitHole
{
    class RabbitHole
    {
        static void Main(string[] args)
        {
            List<string> obstacles = Console.ReadLine().Split().ToList();
            int energy = int.Parse(Console.ReadLine());

            int i = 0;
            bool deathOfBomb = false;
            bool rabbitHole = false;

            while (energy > 0)
            {
                if (obstacles[i] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    rabbitHole = true;
                    break;
                }
                else
                {
                    string[] obj = obstacles[i].Split('|').ToArray();
                    string action = obj[0];
                    int moves = int.Parse(obj[1]);

                    if (action == "Left")
                    {
                        i = Math.Abs(i - moves) % obstacles.Count;
                        energy -= moves;
                    }
                    else if (action == "Right")
                    {
                        i = (i + moves) % obstacles.Count;
                        energy -= moves;
                    }
                    else if (action == "Bomb")
                    {
                        obstacles.Remove(obstacles[i]);
                        i = 0;
                        energy -= moves;

                        if (energy <= 0)
                        {
                            Console.WriteLine("You are dead due to bomb explosion!");
                            deathOfBomb = true;
                            break;
                        }
                    }
                }

                if (obstacles[obstacles.Count-1] == "RabbitHole")
                {
                    obstacles.Add($"Bomb|{energy}");
                }
                else
                {
                    obstacles.RemoveAt(obstacles.Count - 1);
                    obstacles.Add($"Bomb|{energy}");
                }
            }

            if (rabbitHole == false && deathOfBomb == false)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }
        }
    }
}