using System;

class ex012
{
    static void Main()
    {
        double produto, desconto, valor_final; 
        Console.Write("Qual o preço do produto? R$");
        produto = double.Parse(Console.ReadLine());
        desconto = produto * 0.05;
        valor_final = produto - desconto;
        Console.WriteLine($"O produto que custava R${produto} passa a custar R${valor_final} com 5% de desconto.");
    }
}
