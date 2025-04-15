using System;

class Program
{
    static void Main(string[] args)
    {
        int preco_dia = 60;
        float preco_km = 0.15f;

        Console.Write("Quantos dias alugados? ");
        int user_dias = int.Parse(Console.ReadLine());

        Console.Write("Quantos Km rodados? ");
        float user_km = float.Parse(Console.ReadLine());

        float custo_total = (user_dias * preco_dia) + (preco_km * user_km);
        Console.WriteLine($"O total a pagar é de R${custo_total:F2}");
    }
}
