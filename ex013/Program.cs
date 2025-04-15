using System;
using System.Security.AccessControl;

class ex013
{
    static void Main()
    {
        double salario, aumento;
        Console.Write("Qual é o salário do Funcionário? R$");
        salario = double.Parse(Console.ReadLine());
        aumento = salario * 1.15;
        Console.Write($"O funcionário que ganhava R${salario} passa a ganhar R${aumento:F2} com 15% de aumento.");
    }
}
