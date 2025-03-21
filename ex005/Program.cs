using System;

class ex005
{
    static void Main()
    {
        int num;

        Console.Write("Digite um número: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"O sucessor de {num} é {num+1} e o antecessor é {num-1}");
    }
}
