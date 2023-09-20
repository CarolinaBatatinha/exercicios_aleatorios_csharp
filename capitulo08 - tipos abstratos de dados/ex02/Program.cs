using System;
using System.Linq;
using TAD;


public class Program
{
    public static void Main()
    {
        GerenciadorDePessoas gerenciador = new GerenciadorDePessoas(10);

        gerenciador.Adicionar(new Pessoa("João", "Silva", "Masculino"));
        gerenciador.Adicionar(new Pessoa("Maria", "Oliveira", "Feminino"));
        gerenciador.Adicionar(new Pessoa("Bruno", "Castro", "Masculino"));
        gerenciador.Adicionar(new Pessoa("Pedro", "Calixto", "Masculino"));

        Console.WriteLine("Lista de Pessoas:");
        gerenciador.ListarPessoas();

        var encontrada = gerenciador.LocalizarPeloNome("Bruno");
        if (encontrada != null)
        {
            Console.WriteLine($"Pessoa encontrada: {encontrada}");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada.");
        }

        gerenciador.RemoverPeloNome("Pedro");
        Console.WriteLine("\nLista após remoção:");
        gerenciador.ListarPessoas();
    }
}