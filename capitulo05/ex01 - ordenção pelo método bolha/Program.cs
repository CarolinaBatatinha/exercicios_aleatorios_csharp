class Program
{
    static void Main(string[] args)
    {
        int[] vetor = { 99, 82, 50, 67, 90, 20, 71, 8, 21, 18 };
        OrdenarEmBolha(vetor);

        Console.WriteLine("\nVetor ordenado: ");

        foreach (int numero in vetor)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }

    static void OrdenarEmBolha(int[] vetor)
    {
        int tamanho = vetor.Length;
        for (int i = 0; i < tamanho - 1; i++)
        {
            for (int j = 0; j < tamanho - i - 1; j++)
            {
                if (vetor[j] > vetor[j + 1])
                {
                    int temp = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = temp;
                }
            }
        }
    }
}
