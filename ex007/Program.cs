using System;

class ex007
{
    static void Main()
    {
        double notaUm, notaDois, media;
        Console.Write("Digite a primeira nota: ");
        notaUm = double.Parse(Console.ReadLine());
        Console.Write("Digite a segunda nota: ");
        notaDois = double.Parse(Console.ReadLine());
        media = (notaUm + notaDois) / 2;
        Console.WriteLine($"A média do aluno foi {media}");
    }
}
