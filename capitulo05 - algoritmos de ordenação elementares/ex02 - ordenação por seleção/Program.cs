// int[] vetor = { 99, 82, 50, 67, 90, 20, 71, 8, 21, 18 };
// int min, temp;
// for (int i = 0; i < vetor.Length - 1; i++)
// {
//     min = i; // o "mínimo" recebe o primeiro número no vetor e o assume como sendo o menor número
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
    static void PorSelecao(int[] vetor)
    {
        int n = vetor.Length;
        for (int i = 0; i < n - 1; i++)
        {
            // Encontra o índice  do menor elemento na sublista não ordenada
            int minIndex = i;
            for (int j = i+1; j < n; j++)
            {
                if (vetor[j] < vetor[minIndex])
                {
                    minIndex = j;
                }
            }
            //Troca o elemento encontrado com o elemento na posição atual
            int temp = vetor[minIndex];
            vetor[minIndex] = vetor[i];
            vetor[i] = temp;
        }
    }
    static void Main(string[] args)
    {
        int[] vetor = { 64, 25, 12, 22, 11 };
        PorSelecao(vetor);

        Console.WriteLine("\nVetor ordenado:");
        foreach (int num in vetor)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
