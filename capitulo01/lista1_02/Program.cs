// Escreva um programa em C# que declare um vetor de inteiros com valores predefinidos. Calcule a média dos valores contidos no vetor e imprima o resultado na tela.

using System;

namespace lista1_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 1, 2, 3, 4, 5 };
            int soma = 0;
            
            foreach (int numero in vetor)
            {
                soma += numero;
            }
            
            double media = (double)soma / vetor.Length;

            Console.WriteLine($"A média dos valores contidos no vetor é igual a {media}");
        }
    }
}