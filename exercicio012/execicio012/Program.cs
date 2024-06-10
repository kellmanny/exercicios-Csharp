using System;
using System.Globalization;

class ex012
{

    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        String nome = Console.ReadLine();

        Console.Write("Digite seu sálario: ");
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Quanto vendeu de comissão dinheiro? ");
        double comissao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        double bonus =  + comissao * 0.15;

        double salarioFinal = salario + bonus;

        Console.WriteLine("TOTAL = R$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));




    }

}