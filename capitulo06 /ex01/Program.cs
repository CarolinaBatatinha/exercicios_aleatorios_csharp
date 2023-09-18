//RESOLVENDO O PROBLEMA DO CÁLCULO DE FATORIAL USANDO A RECURSIVIDADE

class Program
{
    public static int FatIterativo(int numero)
    {
        int resultado = 1;
        while (numero >= 1)
        {
            resultado *= numero;
            numero--;
        }
        return resultado;
    }

    public static int FibIterativo(int numero) //SOLUÇÃO ITERATIVA PARA O CÁLCULO DO N-ÉSIMO TERMO DA SEQUENCIA DE FIBONACCI
    {
        int num1 = 1;
        int num2 = 1;
        int proxNum = 0;

        for (int i = 3; i <= numero; i++)
        {
            proxNum = num1 + num2;
            num1 = num2;
            num2 = proxNum;
        }
        return proxNum;
    }


    public static void Main(string[] args)
    {
        int exemplo1 = FatIterativo(3);
        int exemplo2 = FibIterativo(4);
        Console.WriteLine(exemplo1);
        Console.WriteLine(exemplo2);
    }
}