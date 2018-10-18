using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProblemNo2 // mnogo shibana taya zadacha - 80/100 i s regex i bez ...
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "Worm Ipsum")
            {
                //if (input[input.Length - 1] == '.' && (input[0] < 97 || input[0] > 122))
                //{
                //    if (input[input.Length - 2] == '.')
                //    {
                //        List<string> inputParams = input.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                //        if (inputParams.Count == 1)
                //        {
                //            List<string> words = input.Split(' ').ToList();
                //            string resultSentence = string.Empty;

                //            Dictionary<char, int> charactersCount = new Dictionary<char, int>();

                //            for (int i = 0; i < words.Count; i++)
                //            {
                //                string word = words[i];

                //                charactersCount = GetMaxCharValues(charactersCount, word);

                //                int maxCount = 1;
                //                char characterMaxCount = '\n';

                //                foreach (var kvp in charactersCount)
                //                {
                //                    char character = kvp.Key;
                //                    int count = kvp.Value;

                //                    if (count > maxCount)
                //                    {
                //                        maxCount = count;
                //                        characterMaxCount = character;
                //                    }
                //                }

                //                words = ReplaceWords(words, i, maxCount, characterMaxCount, word);

                //                charactersCount = new Dictionary<char, int>();
                //            }

                //            resultSentence = string.Join(" ", words);

                //            Console.WriteLine(resultSentence);
                //        }
                //    }
                //    else
                //    {
                //        List<string> inputParams = input.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                //        string sentence = string.Empty;
                //        string resultSentence = string.Empty;
                //        bool isValid = false;

                //        if (inputParams.Count == 1)
                //        {
                //            sentence = inputParams[0] + '.';
                //            isValid = true;

                //            List<string> words = sentence.Split(new[] { ' ' }).ToList();
                //            Dictionary<char, int> charactersCount = new Dictionary<char, int>();

                //            for (int k = 0; k < words.Count; k++)
                //            {
                //                string word = words[k];

                //                charactersCount = GetMaxCharValues(charactersCount, word);

                //                int maxCount = 1;
                //                char characterMaxCount = '\n';

                //                foreach (var kvp in charactersCount)
                //                {
                //                    char character = kvp.Key;
                //                    int count = kvp.Value;

                //                    if (count > maxCount)
                //                    {
                //                        characterMaxCount = character;
                //                        maxCount = count;
                //                    }
                //                }

                //                words = ReplaceWords(words, k, maxCount, characterMaxCount, word);

                //                charactersCount = new Dictionary<char, int>();
                //            }

                //            resultSentence = String.Join(" ", words);
                //        }

                //        if (isValid)
                //        {
                //            Console.WriteLine(resultSentence);
                //        }
                //    }
                //}

                TrySolutionWithRegex(input);

                input = Console.ReadLine();
            }
        }
        static Dictionary<char, int> GetMaxCharValues(Dictionary<char, int> charactersCount, string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!charactersCount.ContainsKey(word[i]))
                {
                    charactersCount[word[i]] = 0;
                }

                charactersCount[word[i]]++;
            }

            return charactersCount;
        }
        static List<string> ReplaceWords(List<string> words, int k, int maxCount, char characterMaxCount, string word)
        {
            if (words[k][words[k].Length - 1] == '.')
            {
                if (characterMaxCount != '\n' && maxCount > 1)
                {
                    if (k == words.Count - 1)
                    {
                        words[k] = new string(characterMaxCount, word.Length - 1) + '.';
                    }
                    else
                    {
                        words[k] = new string(characterMaxCount, word.Length);
                    }
                }
            }
            else
            {
                if (characterMaxCount != '\n' && maxCount > 1)
                {
                    if (k <= words.Count - 1)
                    {
                        words[k] = new string(characterMaxCount, word.Length);
                    }
                }
            }

            return words;
        }
        static void TrySolutionWithRegex(string input)
        {
            Regex regex = new Regex(@"(^[A-Z])(.+)([.])");
            Dictionary<char, int> charactersCount = new Dictionary<char, int>();
            string resultSentence = string.Empty;

            Match matches = regex.Match(input);

            List<string> check = matches.ToString().Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (check.Count == 1)
            {
                if (matches.ToString() != "")
                {
                    List<string> match = matches.ToString().Split(' ').ToList();

                    for (int i = 0; i < match.Count; i++)
                    {
                        string word = match[i];

                        charactersCount = GetMaxCharValues(charactersCount, word);

                        int maxCount = 1;
                        char characterMaxCount = '\n';

                        foreach (var kvp in charactersCount)
                        {
                            char character = kvp.Key;
                            int count = kvp.Value;

                            if (count > maxCount)
                            {
                                maxCount = count;
                                characterMaxCount = character;
                            }
                        }

                        match = ReplaceWords(match, i, maxCount, characterMaxCount, word);

                        charactersCount = new Dictionary<char, int>();
                    }

                    resultSentence = string.Join(" ", match);

                    Console.WriteLine(resultSentence);
                }
            }
        }
    }
}
