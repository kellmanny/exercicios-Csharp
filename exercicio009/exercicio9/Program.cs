using System;
using System.Globalization;

class ex9
{
    static void Main(string[] args)
    {
        int horas = int.Parse(Console.ReadLine());
        int velocidade = int.Parse(Console.ReadLine());

        double distancia = horas * velocidade;

        double Qdlitros = distancia / 12;

        Console.WriteLine(Qdlitros.ToString("F3", CultureInfo.InvariantCulture));


    }

}