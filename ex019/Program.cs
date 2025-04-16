using System;

class ex019 {
    static void Main() {
        string[] alunos = new string[4];
        for(int i = 0; i < alunos.Length; i++) {
            Console.Write($"Digite o nome do {i+1}º aluno: ");
            alunos[i] = Console.ReadLine();
        }

        Random sorteio = new Random();

        int Sorteado = sorteio.Next(alunos.Length);

        Console.WriteLine($"O aluno sorteado foi {alunos[Sorteado]}");
    }
}
