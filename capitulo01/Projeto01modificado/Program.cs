using System;
class Program
{
    static double CalcularMedia(double[] notas)
    {
        double soma = 0;

        for (int i = 0; i < notas.Length; i++)
            soma += notas[i];
        return soma / notas.Length;
    }

    static void Main(string[] args)
    {
        double[] notas = { 8.7, 5.4, 6.2 };
        double media = CalcularMedia(notas);

        Console.WriteLine($"A média da turma é {media:F1}.");
    }
}
