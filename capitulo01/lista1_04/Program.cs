//Crie um programa em C# que declare um vetor de inteiros com valores predefinidos. Contabilize e imprima a quantidade de números pares e ímpares presentes no vetor.

using System;

namespace lista1_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 24, 36, 17, 23, 13, 1, 12 };
            int pares = 0;
            int impares = 0;

            foreach (int numero in vetor)
            {
                if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            Console.WriteLine($"O vetor tem {pares} números pares e {impares} números ímpares.");
        }
    }
}
