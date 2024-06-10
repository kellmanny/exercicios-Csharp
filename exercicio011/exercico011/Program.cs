using System;
using System.Globalization;

class ex011
{
    static void Main(string[] args)
    {
        double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double pesoA = 2;
        double pesoB = 3;
        double pesoC = 5;

        double somaDosPesos = pesoA + pesoB + pesoC;

        double media = (A * pesoA + B * pesoB + C * pesoC) / somaDosPesos;

        Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
    }

}