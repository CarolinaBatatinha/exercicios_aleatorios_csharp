using System;

class Program
{
    static void Main(string[] args)
    {
        double[] notas = { 6.3, 5.7, 8.0 };

        Console.WriteLine(notas[0]);
        Console.WriteLine(notas[2]);

        notas[0] = 7.5; // COMO SE ATRIBUI OUTRO VALOR A UM ITEM DO VETOR

        Console.WriteLine(notas[0]);

        //USANDO FOR!

        double[] notasT1 = new double[30];

        for (int i = 0; i < notas.Length; i++) 
        {
            Console.WriteLine(notas[i]);
        } 
    }
}