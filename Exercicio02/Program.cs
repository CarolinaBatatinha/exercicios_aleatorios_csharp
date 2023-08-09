//Desenvolva um programa que encontre e exiba o maior número em um vetor de números inteiros.

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho do vetor: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[tamanho];
            int maiorNumero = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                }
            }
            Console.WriteLine($"\nO maior número digitado no vetor é {maiorNumero}.");
        }
    }
}
