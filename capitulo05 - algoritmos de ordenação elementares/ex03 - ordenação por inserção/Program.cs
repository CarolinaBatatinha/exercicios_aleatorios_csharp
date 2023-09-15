// int[] vetor = { 99, 82, 50, 67, 90, 20, 71, 8, 21, 18 };
// int min,temp;
// for (int i = 0; i < vetor.Length - 1; i++)
// {
//     min = i;
//     for (int pos = (i + 1); pos < vetor.Length; pos++)
//     {
//         if (vetor[pos] < vetor[min])
//         {
//             min = pos;
//         }
//     }
//     if (vetor[i] != vetor[min])
//     {
//         temp = vetor[i];
//         vetor[i] = vetor[min];
//         vetor[min] = temp;
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = { 12, 11, 13, 5, 8 };
        PorInsercao(vetor);

        Console.WriteLine("\nVetor ordenado:");

        foreach (int num in vetor)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void PorInsercao(int[] vetor)
    {
        int tamanho = vetor.Length;
        for (int i = 0; i < tamanho; i++)
        {
            int chave = vetor[i];
            int j = i - 1;

            // Move os elementos maiores do que a chave para a direita
            while (j >= 0 && vetor[j] > chave)
            {
                vetor[j + 1] = vetor[j];
                j--;
            }

            //Insere a chave na posição correta
            vetor[j + 1] = chave;
        }
    }
}
