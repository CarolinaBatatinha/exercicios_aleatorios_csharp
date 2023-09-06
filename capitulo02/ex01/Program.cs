// Crie um programa em C# que declare duas matrizes quadradas de ordem 3x3. Preencha essas matrizes com valores inteiros de sua escolha. Em seguida, crie uma terceira matriz que armazene a soma dos elementos correspondentes das duas matrizes anteriores. Imprima a matriz resultante.

class Program
{
    public static void Main(string[] args)
    {
        int[,] matriz1 = new int[3, 3];
        int[,] matriz2 = new int[3, 3];
        int[,] matrizSomada = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0;j < 3; j++)
            {
                Console.Write($"Informe o valor para a posição [{i}, {j}] da primeira matriz: ");
                matriz1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine(" ");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Informe o valor para a posição [{i}, {j}] da segunda matriz: ");
                matriz2[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine(" ");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrizSomada[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrizSomada[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
