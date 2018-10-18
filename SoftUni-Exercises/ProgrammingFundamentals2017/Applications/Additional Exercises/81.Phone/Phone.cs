using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81.Phone
{
    class Phone
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] namesCorrespondingToPhoneNumbersIndex = Console.ReadLine().Split(' ').ToArray();
            string callOrMessage = Console.ReadLine();

            string[] trimmedPhoneNumbers = new string[phoneNumbers.Length];
            trimmedPhoneNumbers = TrimNumber(phoneNumbers);

            while (callOrMessage != "done")
            {
                for (int index = 0; index < namesCorrespondingToPhoneNumbersIndex.Length; index++)
                {
                    if (callOrMessage == $"call {namesCorrespondingToPhoneNumbersIndex[index]}")
                    {
                        Console.WriteLine("calling {0}...", phoneNumbers[index]);

                        int sum = 0;
                        string phoneNumberToName = trimmedPhoneNumbers[index];

                        for (int i = 0; i < phoneNumberToName.Length; i++)
                        {
                            sum += int.Parse(phoneNumberToName[i].ToString());
                        }

                        if (sum % 2 != 0)
                        {
                            Console.WriteLine("no answer");
                        }
                        else
                        {
                            TimeSpan time = TimeSpan.FromSeconds(sum);
                            int seconds = (int)time.Seconds;
                            int minutes = (int)time.Minutes;

                            Console.WriteLine("call ended. duration: {0:00}:{1:00}", minutes, seconds);
                        }
                    }
                    else if (callOrMessage == $"call {phoneNumbers[index]}")
                    {
                        Console.WriteLine("calling {0}...", namesCorrespondingToPhoneNumbersIndex[index]);

                        int sum = 0;
                        string phoneNumberToName = trimmedPhoneNumbers[index];

                        for (int i = 0; i < phoneNumberToName.Length; i++)
                        {
                            sum += int.Parse(phoneNumberToName[i].ToString());
                        }

                        if (sum % 2 != 0)
                        {
                            Console.WriteLine("no answer");
                        }
                        else
                        {
                            TimeSpan time = TimeSpan.FromSeconds(sum);
                            int seconds = (int)time.Seconds;
                            int minutes = (int)time.Minutes;

                            Console.WriteLine("call ended. duration: {0:00}:{1:00}", minutes,seconds);
                        }
                    }
                    else if (callOrMessage == $"message {namesCorrespondingToPhoneNumbersIndex[index]}")
                    {
                        Console.WriteLine("sending sms to {0}...", phoneNumbers[index]);

                        int difference = 0;
                        string phoneNumberToName = trimmedPhoneNumbers[index];

                        for (int i = 0; i < phoneNumberToName.Length; i++)
                        {
                            difference -= int.Parse(phoneNumberToName[i].ToString());
                        }

                        if (difference % 2 != 0)
                        {
                            Console.WriteLine("busy");
                        }
                        else
                        {
                            Console.WriteLine("meet me there");
                        }
                    }
                    else if (callOrMessage == $"message {phoneNumbers[index]}")
                    {
                        Console.WriteLine("sending sms to {0}...", namesCorrespondingToPhoneNumbersIndex[index]);

                        int difference = 0;
                        string phoneNumberToName = trimmedPhoneNumbers[index];

                        for (int i = 0; i < phoneNumberToName.Length; i++)
                        {
                            difference -= int.Parse(phoneNumberToName[i].ToString());
                        }

                        if (difference % 2 != 0)
                        {
                            Console.WriteLine("busy");
                        }
                        else
                        {
                            Console.WriteLine("meet me there");
                        }
                    }
                }

                callOrMessage = Console.ReadLine();
            }
        }

        static string[] TrimNumber(string[] phoneNumbers)
        {
            string[] trimmedPhoneNumbers = new string[phoneNumbers.Length];

            for (int i = 0; i < trimmedPhoneNumbers.Length; i++)
            {
                trimmedPhoneNumbers[i] = phoneNumbers[i];
            }

            for (int i = 0; i < trimmedPhoneNumbers.Length; i++)
            {
                if (trimmedPhoneNumbers[i].Contains("+"))
                {
                    trimmedPhoneNumbers[i] = trimmedPhoneNumbers[i].Trim(new char[] { '+' });
                }
                if (trimmedPhoneNumbers[i].Contains("-"))
                {
                    trimmedPhoneNumbers[i] = trimmedPhoneNumbers[i].Replace("-", string.Empty);
                }
                if (trimmedPhoneNumbers[i].Contains("("))
                {
                    trimmedPhoneNumbers[i] = trimmedPhoneNumbers[i].Replace("(", string.Empty);
                }
                if (trimmedPhoneNumbers[i].Contains(")"))
                {
                    trimmedPhoneNumbers[i] = trimmedPhoneNumbers[i].Replace(")", string.Empty);
                }
            }

            return trimmedPhoneNumbers;
        }
    }
}
