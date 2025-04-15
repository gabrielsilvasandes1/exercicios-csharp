using System;
using System.Formats.Asn1;

class ex011
{
    static void Main()
    {
        double largura, altura, area;
        Console.Write("Qual a largura? ");
        largura = double.Parse(Console.ReadLine());
        Console.Write("Qual a altura? ");
        altura = double.Parse(Console.ReadLine());
        area = largura * altura;
        Console.WriteLine($"{largura}x{altura} corresponde a área de {area:F2}m²");
    }
}
