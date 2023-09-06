// Escreva um programa que receba uma matriz como entrada e retorne a matriz transposta. A matriz transposta é obtida trocando as linhas pelas colunas da matriz original.

class Program
{
    public static void Main(string[] args)
    {
        int[,] matriz = new int[2, 2];
        int[,] matrizTransposta = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine($"Digite o valor de [{i}, {j}] na matriz: ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)            
            {
                matrizTransposta[j, i] = matriz[i, j];
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Resultado da matriz transposta");
        
        for (int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                Console.Write(matrizTransposta[i,j] + " \t");
            }
            Console.WriteLine();
        }
    }
}