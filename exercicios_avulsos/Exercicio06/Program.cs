// Declare um vetor de 10 posições e o preencha com os 10 primeiros números impares e o escreva.

using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int numeroImpar = 1;
            
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = numeroImpar;
                numeroImpar += 2;
            }
            Console.WriteLine("Vetor de números ímpares: ");

            foreach (int numero in vetor)
            {
                Console.Write(numero + " ");
            }
        }
    }
}
