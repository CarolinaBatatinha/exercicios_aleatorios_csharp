// Crie um programa que calcule e mostre a média dos elementos em um vetor de números reais.

using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nDigite o número de elementos dentro do vetor: ");
            int tamanhoVetor = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[tamanhoVetor];
            int soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Informe o {i + 1}º número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                soma += numeros[i];
            }

            int media = soma / numeros.Length;

            Console.Write($"\nA média dos valores dentro do vetor é igual a {media}");
        }
    }
}
