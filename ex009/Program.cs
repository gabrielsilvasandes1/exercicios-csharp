using System;

class ex009
{
    static void Main()
    {
        int user;
        Console.Write("Qual tabuada você deseja ver? ");
        user = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{user} x {i} = {user*i}");
        }
        ;
    }
}
