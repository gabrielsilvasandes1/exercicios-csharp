using System;

class ex006
{
    static void Main()
    {
        double num;
        Console.Write("Digite um número: ");
        num = double.Parse(Console.ReadLine());
        double ValorBase = num;
        double exponent = 3;
        double triplo = num * 3;
        double dobro = num * 2;
        double RaizQuadrada = Math.Sqrt(num);
        Console.WriteLine($"O triplo de {num} é {triplo}");
        Console.WriteLine($"O dobro de {num} é {dobro}");
        Console.WriteLine($"A raiz quadrada de {num} é {RaizQuadrada}");
    }
}
