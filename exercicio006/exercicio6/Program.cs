using System;
using System.Globalization;
class ex6
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



        double DIFERENÇA = (salario * horas);

        Console.WriteLine("NUMBER = " + number);
        Console.WriteLine("SALARY = U$ " + DIFERENÇA.ToString("F2", CultureInfo.InvariantCulture));
    }
}