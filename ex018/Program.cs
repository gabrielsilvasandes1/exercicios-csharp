using System;
using static System.Console;

class Program
{
    static void Main()
    {
        Write("Digite o ângulo que você deseja? ");
        int angulo = int.Parse(ReadLine());

        double rad = angulo * (Math.PI / 180);

        double seno = Math.Sin(rad);
        double cosseno = Math.Cos(rad);
        double tangente = Math.Tan(rad);

        WriteLine($"O ângulo de {angulo}° tem o SENO de {seno:F2}");
        WriteLine($"O ângulo de {angulo}° tem o COSSENO de {cosseno:F2}");
        WriteLine($"O ângulo de {angulo}° tem a TANGENTE de {tangente:F2}");
    }
}

