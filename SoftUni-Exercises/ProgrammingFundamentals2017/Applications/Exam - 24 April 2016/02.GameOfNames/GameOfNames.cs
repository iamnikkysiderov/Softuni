using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GameOfNames
{
    class GameOfNames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> players = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string nameOfPlayer = Console.ReadLine();
                int scoreOfPlayer = int.Parse(Console.ReadLine());

                for (int j = 0; j < nameOfPlayer.Length; j++)
                {
                    char character = nameOfPlayer[j];

                    if (character % 2 == 0)
                    {
                        scoreOfPlayer += character;
                    }
                    else
                    {
                        scoreOfPlayer -= character;
                    }
                }

                players[nameOfPlayer] = scoreOfPlayer;
            }

            foreach (var player in players.OrderByDescending(x => x.Value))
            {
                string name = player.Key;
                int score = player.Value;

                Console.WriteLine("The winner is {0} - {1} points", name, score);

                break;
            }
        }
    }
}
