using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _144.HandsOfCards // nereshena
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerDraw = Console.ReadLine();
            Dictionary<string, int> pointsForEveryPlayer = new Dictionary<string, int>();
            Dictionary<string, List<string>> cards = new Dictionary<string, List<string>>();

            while (playerDraw != "JOKER")
            {
                List<string> tokens = playerDraw.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string player = tokens[0];
                tokens.RemoveAt(0);
                List<string> drawedCards = tokens.Distinct().ToList();

                if (!cards.ContainsKey(player))
                {
                    cards[player] = new List<string>();
                }

                foreach (var card in cards[player])
                {
                    if (drawedCards.Contains(card))
                    {
                        drawedCards.Remove(card);
                    }
                }
                
                cards[player].AddRange(drawedCards);

                int value = 0;
                value = CalculateValue(drawedCards, value);

                if (!pointsForEveryPlayer.ContainsKey(player))
                {
                    pointsForEveryPlayer[player] = 0;
                }
                pointsForEveryPlayer[player] += value;

                playerDraw = Console.ReadLine();
            }

            foreach (var kvp in pointsForEveryPlayer)
            {
                string name = kvp.Key;
                int value = kvp.Value;

                Console.WriteLine($"{name} {value}");
            }
        }

        static int CalculateValue(List<string> drawedCards, int value)
        {
            foreach (var card in drawedCards)
            {
                switch (card[0])
                {
                    case '1':
                        if (card[1] == '0')
                        {
                            switch (card[2])
                            {
                                case 'S':
                                    value += 10 * 4;
                                    break;
                                case 'H':
                                    value += 10 * 3;
                                    break;
                                case 'D':
                                    value += 10 * 2;
                                    break;
                                case 'C':
                                    value += 10;
                                    break;
                            }
                        }
                        break;
                    case '2':
                        switch (card[1])
                        {
                            case 'S':
                                value += 2 * 4;
                                break;
                            case 'H':
                                value += 2 * 3;
                                break;
                            case 'D':
                                value += 2 * 2;
                                break;
                            case 'C':
                                value += 2;
                                break;
                        }
                        break;
                    case '3':
                        switch (card[1])
                        {
                            case 'S':
                                value += 3 * 4;
                                break;
                            case 'H':
                                value += 3 * 3;
                                break;
                            case 'D':
                                value += 3 * 2;
                                break;
                            case 'C':
                                value += 3;
                                break;
                        }
                        break;
                    case '4':
                        switch (card[1])
                        {
                            case 'S':
                                value += 4 * 4;
                                break;
                            case 'H':
                                value += 4 * 3;
                                break;
                            case 'D':
                                value += 4 * 2;
                                break;
                            case 'C':
                                value += 4;
                                break;
                        }
                        break;
                    case '5':
                        switch (card[1])
                        {
                            case 'S':
                                value += 5 * 4;
                                break;
                            case 'H':
                                value += 5 * 3;
                                break;
                            case 'D':
                                value += 5 * 2;
                                break;
                            case 'C':
                                value += 5;
                                break;
                        }
                        break;
                    case '6':
                        switch (card[1])
                        {
                            case 'S':
                                value += 6 * 4;
                                break;
                            case 'H':
                                value += 6 * 3;
                                break;
                            case 'D':
                                value += 6 * 2;
                                break;
                            case 'C':
                                value += 6;
                                break;
                        }
                        break;
                    case '7':
                        switch (card[1])
                        {
                            case 'S':
                                value += 7 * 4;
                                break;
                            case 'H':
                                value += 7 * 3;
                                break;
                            case 'D':
                                value += 7 * 2;
                                break;
                            case 'C':
                                value += 7;
                                break;
                        }
                        break;
                    case '8':
                        switch (card[1])
                        {
                            case 'S':
                                value += 8 * 4;
                                break;
                            case 'H':
                                value += 8 * 3;
                                break;
                            case 'D':
                                value += 8 * 2;
                                break;
                            case 'C':
                                value += 8;
                                break;
                        }
                        break;
                    case '9':
                        switch (card[1])
                        {
                            case 'S':
                                value += 9 * 4;
                                break;
                            case 'H':
                                value += 9 * 3;
                                break;
                            case 'D':
                                value += 9 * 2;
                                break;
                            case 'C':
                                value += 9;
                                break;
                        }
                        break;
                    case 'J':
                        switch (card[1])
                        {
                            case 'S':
                                value += 11 * 4;
                                break;
                            case 'H':
                                value += 11 * 3;
                                break;
                            case 'D':
                                value += 11 * 2;
                                break;
                            case 'C':
                                value += 11;
                                break;
                        }
                        break;
                    case 'Q':
                        switch (card[1])
                        {
                            case 'S':
                                value += 12 * 4;
                                break;
                            case 'H':
                                value += 12 * 3;
                                break;
                            case 'D':
                                value += 12 * 2;
                                break;
                            case 'C':
                                value += 12;
                                break;
                        }
                        break;
                    case 'K':
                        switch (card[1])
                        {
                            case 'S':
                                value += 13 * 4;
                                break;
                            case 'H':
                                value += 13 * 3;
                                break;
                            case 'D':
                                value += 13 * 2;
                                break;
                            case 'C':
                                value += 13;
                                break;
                        }
                        break;
                    case 'A':
                        switch (card[1])
                        {
                            case 'S':
                                value += 14 * 4;
                                break;
                            case 'H':
                                value += 14 * 3;
                                break;
                            case 'D':
                                value += 14 * 2;
                                break;
                            case 'C':
                                value += 14;
                                break;
                        }
                        break;
                }
            }

            return value;
        }
    }
}
