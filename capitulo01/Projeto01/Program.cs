using System;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Defina quantos alunos há na turma: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());
            double[] notas = new double[tamanho];

            //Armazenando as notas
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Digite a nota do {i + 1}º aluno: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            //Recuperando as notas para calcular a média
            double soma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Nota do {i + 1}º aluno: {notas[i]:F1}");
                soma += notas[i];
            }

            double media = soma / notas.Length;
            Console.WriteLine($"A média das notas na turma é de {media:F1}.");
        }
    }
}
