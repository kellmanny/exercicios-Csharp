using System;
using System.Globalization;

class ex010
{
    static void Main(string[] args)
    {
        double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double pesoA = 3.5;
        double pesoB = 7.5;

        double somaDosPesos = pesoA + pesoB;

        double media = (A * pesoA + B * pesoB) / somaDosPesos;

        Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
    }

}