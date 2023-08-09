// Faça um programa que conte quantos números pares estão presentes em um vetor de números inteiros.

using System;

namespace Exercicio04
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("\nQuantos números dentro desse vetor?: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[tamanho];
            int pares = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número do vetor: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    pares++;
                }
            }
            Console.Write($"\nDentro desse vetor, existem {pares} números pares. ");
        }
    }
}