using System;
using System.Globalization;

class ex7
{
    static void Main(string[] args)
    {
        int X = int.Parse(Console.ReadLine());

        double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double totalGasto = (X / Y);

        Console.WriteLine(totalGasto.ToString("F3") + " km/l", CultureInfo.InvariantCulture);


    }

}