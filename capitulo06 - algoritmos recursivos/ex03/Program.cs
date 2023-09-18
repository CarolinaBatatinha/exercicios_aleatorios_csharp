// Implementar uma função recursiva em C# para calcular o fatorial de um número inteiro positivo passado como parâmetro.

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro positivo: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int resultado = Fatoriale(numero);
        Console.WriteLine($"O resultado do fatorial de {numero} é igual a {resultado}");
    }

    public static int Fatoriale(int numero)
    {
        if (numero == 0)
        {
            return 1;
        }
        else
        {
            int rec = numero * Fatoriale(numero - 1);
            return rec;
        }
    }
}
