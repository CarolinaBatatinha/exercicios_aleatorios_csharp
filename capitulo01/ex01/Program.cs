// Escreva um algoritmo que receba dois vetores de números inteiros de mesmo tamanho como entrada e retorne um terceiro vetor que seja a soma dos dois vetores de entrada. Certifique-se de lidar com a adição elemento a elemento.

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Quantas elementos terão os vetores? ");
        int tamanho = Convert.ToInt32(Console.ReadLine());

        int[] vetor1 = new int[tamanho];
        int[] vetor2 = new int[tamanho];
        int[] somaVetores = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o {i + 1}º número do primeiro vetor: ");
            vetor1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(" ");

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o {i + 1}º número do segundo vetor: ");
            vetor2[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(" ");

        for (int i = 0; i < tamanho; i++)
        {
            somaVetores[i] = vetor1[i] + vetor2[i];
        }

        Console.WriteLine("Soma dos elementos dos vetores:");

        for (int i = 0;i < tamanho; i++)
        {
            Console.Write(somaVetores[i] + " ");
        }
    }
}
