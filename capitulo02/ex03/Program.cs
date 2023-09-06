// Crie um programa que receba duas matrizes de números e calcule a soma delas. Certifique-se de que as matrizes tenham as mesmas dimensões para que a soma seja possível.

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe o número de linhas das matrizes: ");
        int tamanhoLinhas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o número de colunas das matrizes: ");
        int tamanhoColunas = Convert.ToInt32(Console.ReadLine());

        int[,] matriz1 = new int[tamanhoLinhas, tamanhoColunas];
        int[,] matriz2 = new int[tamanhoLinhas, tamanhoColunas];
        int[,] somaMatrizes = new int[tamanhoLinhas, tamanhoColunas];

        for (int i = 0; i < tamanhoLinhas; i++)
        {
            for (int j = 0; j < tamanhoColunas; j++)
            {
                Console.Write($"Digite o valor de [{i}, {j}] na primeira matriz: ");
                matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("");

        for (int i = 0; i < tamanhoLinhas; i++)
        {
            for (int j = 0; j < tamanhoColunas; j++)
            {
                Console.Write($"Digite o valor de [{i}, {j}] na segunda matriz: ");
                matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("");

        for (int i = 0; i < tamanhoLinhas; i++)
        {
            for (int j = 0; j < tamanhoColunas; j++)
            {
                somaMatrizes[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        Console.WriteLine("\nResultado da soma das matrizes");

        for (int i = 0; i < tamanhoLinhas; i++)
        {
            for (int j = 0; j < tamanhoColunas; j++)
            {
                Console.Write(somaMatrizes[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
