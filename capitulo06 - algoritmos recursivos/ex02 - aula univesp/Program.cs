class Program
{
    public static int Fat(int numero)
    {
        if (numero == 0) // por definição, o 0! é igual a 1
        {
            return 1;
        }
        else
        {
            int resultado = numero * Fat(numero - 1);
            return resultado;
        }
    }

    public static void Main(String[] args)
    {
        int res = Fat(4);
        Console.WriteLine(res);
    }
}
