using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double granica = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double percentage = Percentage(lastPrice, currentPrice);
            bool isDifference = IsThereADifference(granica, percentage);
            string message = GetPercentageDifference(currentPrice, lastPrice, percentage, isDifference);

            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    static string GetPercentageDifference(double currentPrice, double lastPrice, double percentage, bool isDifference)
    {
        string messageToOutput = string.Empty;

        if (percentage == 0)
        {
            messageToOutput = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isDifference)
        {
            messageToOutput = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percentage * 100);
        }
        else if (isDifference && (percentage > 0))
        {
            messageToOutput = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percentage * 100);
        }
        else if (isDifference && (percentage < 0))
        {
            messageToOutput = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, percentage * 100);
        }
        return messageToOutput;
    }

    static bool IsThereADifference(double granica, double percentage)
    {
        if (Math.Abs(granica) <= Math.Abs(percentage))
        {
            return true;
        }

        return false;
    }

    static double Percentage(double lastPrice, double currentPrice)
    {
        double result = ((currentPrice - lastPrice) / Math.Abs(lastPrice));

        return result;
    }
}
