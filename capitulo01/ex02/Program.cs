// Escreva um programa em C# que declare um vetor de inteiros com valores predefinidos. Calcule a média dos valores contidos no vetor e imprima o resultado na tela.

class Program
{
    public static void Main(string[] args)
    {
        int[] vetor1 = { 1, 2, 3, 4, 5 };
        int soma = 0;

        foreach (int numero in vetor1)
        {
            soma+=numero;
        }

        double media = soma / vetor1.Length;

        Console.WriteLine($"A média dos valores contidos no vetor é igual a {media}");
    }
}
