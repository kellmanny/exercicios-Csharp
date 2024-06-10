using System;
using System.Globalization;

class ex013
{
    static void Main(String[] args)
    {
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double pi = 3.14159;

        double volume = (4.0 / 3.0) * pi * Math.Pow(raio, 3);

        Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
    }
}