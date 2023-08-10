// Desenvolva um programa em C# que declare um vetor de inteiros com valores predefinidos. Encontre e imprima o maior valor presente no vetor.

using System;

namespace lista1_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 6, 44, 82, 57 };
            int maiorNum = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorNum)
                {
                    maiorNum = numeros[i];
                }
            }
            Console.WriteLine($"O maior número do vetor é {maiorNum}");
        }
    }
}
