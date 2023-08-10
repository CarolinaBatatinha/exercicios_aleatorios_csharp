// Crie um programa em C# que declare dois vetores de inteiros com o mesmo tamanho (5 elementos). Preencha os vetores com valores inteiros de sua escolha. Em seguida, crie um terceiro vetor que armazene a soma dos elementos correspondentes dos dois vetores anteriores. Imprima o vetor resultante.

using System;

namespace lista1_01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetorSoma = new int[5];

            for (int numero = 0; numero < 5; numero++)
            {
                Console.Write($"Digite o {numero + 1}º número do 1º vetor: ");
                vetor1[numero] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(" ");

            for (int numero = 0; numero < 5; numero++)
            {
                Console.Write($"Digite o {numero + 1}º número do 2º vetor: ");
                vetor2[numero] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(" ");

            for (int i = 0; i < 5; i++)
            {
                vetorSoma[i] = vetor1[i] + vetor2[i];
            }
            Console.Write("Soma dos elementos correspondentes dos vetores: ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(vetorSoma[i] + " ");
            }
        }
    }    
}
