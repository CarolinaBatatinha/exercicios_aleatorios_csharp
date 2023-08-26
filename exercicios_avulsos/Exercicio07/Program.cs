// Escreva um programa que solicite duas matrizes do mesmo tamanho (por exemplo, 3x3) ao usuário e, em seguida, calcule e imprima a matriz resultante da soma das duas matrizes.

namespace Exercicio08
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de linhas das matrizes: ");
            int linhas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número de colunas das matrizes: ");
            int colunas = Convert.ToInt32(Console.ReadLine());

            int[,] matriz1 = CriarMatrizes(linhas, colunas);
            int[,] matriz2 = CriarMatrizes(linhas, colunas);
            int[,] matrizSomada = SomarMatrizes(matriz1, matriz2);

            Console.WriteLine("Matriz resultante da soma:");
            ImprimirMatriz(matrizSomada);
        }

        static int[,] CriarMatrizes(int linhas, int colunas)
        {
            int[,] matriz = new int[linhas, colunas];

            for (int lin = 0; lin < linhas; lin++)
            {
                for (int col = 0; col < colunas; col++)
                {
                    Console.WriteLine($"Informe o valor para a posição [{lin}, {col}]: ");
                    matriz[lin, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matriz;
        }

        static int[,] SomarMatrizes(int[,] matriz1, int[,] matriz2)
        {
            int linhas = matriz1.GetLength(0);
            int colunas = matriz1.GetLength(1);
            int[,] resultado = new int[linhas, colunas];

            for (int lin = 0; lin < linhas; lin++)
            {
                for (int col = 0; col < colunas; col++)
                {
                    resultado[lin, col] = matriz1[lin, col] + matriz2[lin, col];
                }
            }
            return resultado;
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int lin = 0; lin < linhas; lin++)
            {
                for (int col = 0; col < colunas; col++)
                {
                    Console.Write(matriz[lin, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
