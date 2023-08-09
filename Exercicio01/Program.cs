//Escreva um programa que receba um vetor de números inteiros e calcula a soma de todos os elementos presentes no vetor.

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nInforme o número de elementos do vetor: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++) 
            { 
                Console.Write($"Informe o {i + 1}º número do vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            int soma = 0;

            foreach (int numero in vetor)
            {
                soma += numero;
            }

            Console.WriteLine($"\nA soma dos valores do vetor é igual a {soma}");
        }
    }
}