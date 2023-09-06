// Desenvolva um algoritmo que permita ao usuário multiplicar duas matrizes. Lembre-se de que, para que a multiplicação seja válida, o número de colunas da primeira matriz deve ser igual ao número de linhas da segunda matriz.

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o tamanho das matrizes: ");
        int tamanho = Convert.ToInt32(Console.ReadLine());
        int [,] matriz1 = new int[tamanho, tamanho];
        int [,] matriz2 = new int[tamanho, tamanho];
        int [,] multiplicaMatriz = new int[tamanho,tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write($"Digite o valor de [{i}, {j}] na primeira matriz: ");
                matriz1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("");

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write($"Digite o valor de [{i}, {j}] na segunda matriz: ");
                matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine();

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                multiplicaMatriz [i,j]= matriz1[i, j] * matriz2[i, j];
            }
        }

        Console.WriteLine("Resultado da multiplicação das duas matrizes");

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write(multiplicaMatriz[i,j] + "\t");
            }
            Console.WriteLine() ;
        }
    }
}
