using System;

class SecondSample
{
    static void Main()
    {
        int totalrides = int.Parse(Console.ReadLine());

        int sum = 0;
        int firstGroup = 0;
        int secondGroup = 0;
        int thirdGroup = 0;

        for (int i = 1; i <= totalrides; i++)
        {
            int tonsForTransport = int.Parse(Console.ReadLine());
            sum += tonsForTransport;

            if (tonsForTransport > 0 && tonsForTransport <= 3)
            {
                firstGroup += tonsForTransport;
            }
            else if (tonsForTransport > 3 && tonsForTransport <= 11)
            {
                secondGroup += tonsForTransport;
            }
            else if (tonsForTransport > 11)
            {
                thirdGroup += tonsForTransport;
            }
        }

        int averagePrice = (firstGroup * 200 + secondGroup * 175 + thirdGroup * 120) / sum;
        Console.WriteLine(averagePrice);

        double microbus = firstGroup * 0.25;
        Console.WriteLine("{0:f2}%", microbus);
        double truck = secondGroup * 0.25;
        Console.WriteLine("{0:f2}%", truck);
        double train = thirdGroup * 0.25;
        Console.WriteLine("{0:f2}%", train);
    }
    public static string magicString(string text, int repeatCount)
    {
        string outputText = "";

        for (int i = 0; i < repeatCount; i++)
        {
            outputText += text;
        }

        return outputText;
    }
}