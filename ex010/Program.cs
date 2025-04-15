using System;

class ex010
{
    static void Main()
    {
        double valor;
        Console.Write("Digite o valor: R$");
        valor = double.Parse(Console.ReadLine());
        double conversao = valor / 5.728;
        Console.WriteLine($"R${valor} corresponde a ${conversao:F2} dólares");
    }
}
