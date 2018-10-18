using System;

class DistanceOfTheStars
{
    static void Main(string[] args)
    {
        decimal proxima = 4.22M;
        decimal milkyWay = 26000M * 9450000000000;
        decimal radiusMilkyWay = 100000M * 9450000000000;
        decimal distanceEarth = 46500000000;
        decimal ly = 9450000000000M;

        decimal proximaResult = (decimal)proxima * (decimal)ly;
        decimal resultDistance = (decimal)distanceEarth * (decimal)ly;

        Console.WriteLine(proximaResult.ToString("e2"));
        Console.WriteLine(milkyWay.ToString("e2"));
        Console.WriteLine(radiusMilkyWay.ToString("e2"));
        Console.WriteLine(resultDistance.ToString("e2"));
    }
}