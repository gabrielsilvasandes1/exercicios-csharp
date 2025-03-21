using System;

class ex003
{
    static void Main()
    {
        int n1, n2;
        Console.Write("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"A soma entre {n1} e {n2} é igual a {n1 + n2}");
    }
}
