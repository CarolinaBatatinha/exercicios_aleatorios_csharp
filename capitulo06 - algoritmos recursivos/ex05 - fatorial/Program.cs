// FATORIAL

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro para calcular o fatorial:");
        int n = int.Parse(Console.ReadLine());

        long resultado = Fatorial(n);

        Console.WriteLine($"O fatorial de {n} é {resultado}.");
    }
    static long Fatorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Fatorial(n - 1);
        }
    }
}
