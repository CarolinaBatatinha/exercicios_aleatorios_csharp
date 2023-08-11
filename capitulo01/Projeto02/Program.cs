using System;

class Program
{
    static void Main(string[] args)
    {
        string frase = "A velha debaixo da cama";
        char[] vetor = frase.ToCharArray();
        Array.Reverse(vetor);

        foreach (char letra in vetor)
        {
            Console.Write(letra);
        }
    }
}