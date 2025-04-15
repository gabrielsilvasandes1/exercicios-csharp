using System;

class ex004
{
    static void Main()
    {
        Console.Write("Digite algo: ");
        string input = Console.ReadLine();
        Console.WriteLine($"O tipo primitivo desse valor é {input.GetType()}");
        Console.WriteLine($"Só tem espaços? {input.All(char.IsWhiteSpace)}");
        Console.WriteLine($"É um número? {int.TryParse(input, out _)}");
        Console.WriteLine($"Está em minúsculas? {input == input.ToUpper()}");
        Console.WriteLine($"Está em maiúsculas? {input == input.ToLower()}");
    }
}
