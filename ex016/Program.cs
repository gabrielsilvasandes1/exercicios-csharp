using static System.Console;

Write("Digite um valor: ");
double user = double.Parse(ReadLine());
Write($"O valor digitado foi {user} e sua porção inteira é {(int)user}");

