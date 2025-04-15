using System;
using System.Text;

class ex014
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        double celsius, formula_1, formula_2;
        Console.Write("Digite uma temperatura em ℃: ");
        celsius = double.Parse(Console.ReadLine());
        formula_1 = (celsius * 1.8) + 32;
        Console.Write($"A temperatura de {celsius}\u2103 corresponde a {formula_1}\u2109");
    }
}

