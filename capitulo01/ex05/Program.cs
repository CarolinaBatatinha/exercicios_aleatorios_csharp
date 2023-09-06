using System.ComponentModel.DataAnnotations.Schema;
// Elabore um programa em C# que declare um vetor de strings com nomes predefinidos. Solicite ao usuário um nome para busca. Verifique se o nome está presente no vetor e exiba uma mensagem informando se o nome foi encontrado ou não.

class Program
{
    public static void Main(string[] args)
    {
        string[] vetor = {"Carol", "Leila", "Paulo"};
        Console.WriteLine("\nInsira um nome: ");
        string nomeUsuario = Console.ReadLine();
        bool encontrado = false;

        foreach (string nome in vetor)
        {
            if (nome.Equals(nomeUsuario))
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            Console.WriteLine($"O nome {nomeUsuario} foi encontrado");
        }
        else
        {
            Console.WriteLine($"O nome {nomeUsuario} não foi encontrado");
        }
    }
}