// Implemente um algoritmo que receba um vetor de números e retorne o mesmo vetor, porém com os elementos em ordem inversa.

using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o elemento {i + 1}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] vetorInvertido = InverterVetor(vetor);

            Console.WriteLine("Vetor original:");
            ImprimirVetor(vetor);

            Console.WriteLine("Vetor invertido:");
            ImprimirVetor(vetorInvertido);
        }

        static int[] InverterVetor(int[] vetor)
        {
            int[] vetorInvertido = new int[vetor.Length];
            for (int i = 0; i < vetor.Length; i++)
            {
                vetorInvertido[i] = vetor[vetor.Length - 1 - i];
            }
            return vetorInvertido;
        }

        static void ImprimirVetor(int[] vetor)
        {
            foreach (int elemento in vetor)
            {
                Console.Write(elemento + " ");
            }
        }
    }
}
