// Desenvolva um programa em C# que declare um vetor de inteiros com valores predefinidos. Encontre e imprima o maior valor presente no vetor.

class Program
{
    public static void Main(string[] args)
    {
        int[] vetor = { 1, 12, 3, 4 };
        int maiorNumero = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i]>maiorNumero)
            {
                maiorNumero = vetor[i];
            }
        }
        Console.WriteLine($"O maior número é {maiorNumero}.");
    }
}