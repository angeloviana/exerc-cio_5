using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int Codigo1, Codigo2, Quantidade1, Quantidade2;
        double Preco1, Preco2, Total;


        string[] Valores1 = Console.ReadLine().Split(' ');
        Codigo1 = int.Parse(Valores1[0]);
        Quantidade1 = int.Parse(Valores1[1]);
        Preco1 = double.Parse(Valores1[2], CultureInfo.InvariantCulture);

        string[] Valores2 = Console.ReadLine().Split(' ');
        Codigo2 = int.Parse(Valores2[0]);
        Quantidade2 = int.Parse(Valores2[1]);
        Preco2 = double.Parse(Valores2[2], CultureInfo.InvariantCulture);

        Total = Quantidade1 * Preco1 + Quantidade2 * Preco2;

        Console.WriteLine("Total a pagar: " + Total.ToString("F2", CultureInfo.InvariantCulture));
    }
}