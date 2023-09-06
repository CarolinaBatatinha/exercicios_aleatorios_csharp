//Crie um programa em C# que declare um vetor de inteiros com valores predefinidos. Contabilize e imprima a quantidade de números pares e ímpares presentes no vetor.

class Program
{
    public static void Main(string[] args)
    {
        int[] vetor = { 12, 43, 26, 18, 31 };
        int pares = 0;
        int impares = 0;

        foreach (int numero in vetor)
        {
            if (numero % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }
        Console.WriteLine($"São {pares} números pares e {impares} números ímpares.");
    }
}