using System;

namespace _04.Nilapdromes
{
    class Nilapdromes
    {
        static void Main(string[] args)
        {
            string potentialNilapdrome = Console.ReadLine();

            while (potentialNilapdrome != "end")
            {
                string leftBorder = string.Empty;
                string rightBorder = string.Empty;
                string core = string.Empty;
                bool isNilapdrome = false;

                int i = 0;

                if (potentialNilapdrome.Length % 2 == 0)
                {
                    for (int j = potentialNilapdrome.Length/2; j < potentialNilapdrome.Length; j++)
                    {
                        int temporaryJ = j;
                        int counter = 0;

                        while (potentialNilapdrome[i] == potentialNilapdrome[j])
                        {
                            leftBorder += potentialNilapdrome[i];

                            counter++;

                            if (j == potentialNilapdrome.Length - 1)
                            {
                                break;
                            }

                            i++;
                            j++;
                        }

                        if (j != potentialNilapdrome.Length - 1)
                        {
                            leftBorder = string.Empty;

                            j = temporaryJ;
                            i = 0;
                        }
                        else if (leftBorder != string.Empty && j == potentialNilapdrome.Length - 1)
                        {
                            rightBorder = leftBorder;

                            for (int k = leftBorder.Length; k <= j - counter; k++)
                            {
                                core += potentialNilapdrome[k];
                            }

                            isNilapdrome = true;
                            break;
                        }
                    }
                }
                else
                {
                    for (int j = potentialNilapdrome.Length/2+1; j < potentialNilapdrome.Length; j++)
                    {
                        int temporaryJ = j;
                        int counter = 0;

                        while (potentialNilapdrome[i] == potentialNilapdrome[j])
                        {
                            leftBorder += potentialNilapdrome[i];

                            counter++;

                            if (j == potentialNilapdrome.Length - 1)
                            {
                                break;
                            }

                            i++;
                            j++;
                        }

                        if (j != potentialNilapdrome.Length - 1)
                        {
                            leftBorder = string.Empty;

                            j = temporaryJ;
                            i = 0;
                        }
                        else if (leftBorder != string.Empty && j == potentialNilapdrome.Length - 1)
                        {
                            rightBorder = leftBorder;

                            for (int k = leftBorder.Length; k <= j - counter; k++)
                            {
                                core += potentialNilapdrome[k];
                            }

                            isNilapdrome = true;
                            break;
                        }
                    }
                }


                if (isNilapdrome && (leftBorder + core + rightBorder) == potentialNilapdrome && core != "")
                {
                    Console.WriteLine(core + rightBorder + core);
                }

                potentialNilapdrome = Console.ReadLine();
            }
        }
    }
}
