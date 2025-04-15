using System;

class ex008
{
    static void Main()
    {
        double distancia;
        Console.Write("Digite uma distância em Metros: ");
        distancia = double.Parse(Console.ReadLine());
        double milimetros = distancia * 1000;
        double centimetros = distancia * 100;
        Console.WriteLine($"A distância de {distancia}km corresponde a {milimetros}mm (milímetros) e {centimetros}cm (centímetros)");
    }
}