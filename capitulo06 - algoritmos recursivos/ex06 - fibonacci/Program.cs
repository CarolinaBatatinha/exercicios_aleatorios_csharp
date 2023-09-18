using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o termo n da sequência de Fibonacci que você deseja calcular:");
        int n = int.Parse(Console.ReadLine());

        long resultado = Fibonacci(n);

        Console.WriteLine($"O termo {n} da sequência de Fibonacci é {resultado}.");
    }

    static int Fibonacci(int n)
    {
        if (n <= 0)
        {              
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
