// Desenvolva um programa em C# que crie uma matriz identidade de ordem 4x4. Uma matriz identidade é uma matriz quadrada onde os elementos da diagonal principal são 1 e os demais elementos são 0. Imprima a matriz resultante.

class Program
{
    public static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i ==j)
                {
                    matriz[i, j] = 1;
                }
                else
                { 
                    matriz[i, j] = 0;
                }
            }
        }

        for (int i = 0; i <4; i++)
        {
            for(int j = 0;j<4; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}