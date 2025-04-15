using static System.Console;
Write("Digite o valor do cateto A: ");
double catetoA = Convert.ToDouble(Console.ReadLine());
Write("Digite o valor do cateto B: ");
double catetoB = Convert.ToDouble(Console.ReadLine());
double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));
WriteLine($"A hipotenusa é: {hipotenusa:F2}");
