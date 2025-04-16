using System;

class ex020 {
    static void Main(){
        string[] alunos = new string[4];

        for (int i = 0; i < alunos.Length; i++) {
            Console.Write($"Digite o nome do {i + 1}º aluno: ");
            alunos[i] = Console.ReadLine();
        }
        
        EmbaralharArray(alunos);

        Console.WriteLine("\nAlunos em ordem aleatória:");
        foreach (string aluno in alunos) {
            Console.WriteLine(aluno);
        }
    }

    static void EmbaralharArray (string[] array) {
        Random nums = new Random ();
        for (int i = array.Length - 1; i > 0; i--) {
            int j = nums.Next(i + 1);
            string temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
