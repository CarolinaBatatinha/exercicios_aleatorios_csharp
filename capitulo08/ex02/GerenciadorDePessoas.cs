using System;

namespace TAD
{
    public class GerenciadorDePessoas
    {
        private Pessoa[] pessoas;
        private int count;

        public GerenciadorDePessoas(int capacidade)
        {
            pessoas = new Pessoa[capacidade];
            count = 0;
        }

        public bool Adicionar(Pessoa pessoa)
        {
            if (count < pessoas.Length)
            {
                pessoas[count] = pessoa;
                count++;
                return true;
            }
            return false;
        }

        public bool RemoverPeloNome(string n)
        {
            for (int i = 0; i < count; i++)
            {
                if (pessoas[i].GetNome() == n)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        pessoas[j] = pessoas[j + 1];
                    }
                    pessoas[count - 1] = null;
                    count--;
                    return true;
                }
            }
            return false;
        }

        public Pessoa LocalizarPeloNome(string n)
        {
            for (int i = 0; i < count; i++)
            {
                if (pessoas[i].GetNome() == n)
                    return pessoas[i];
            }
            return null;
        }

        public void ListarPessoas()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(pessoas[i].ToString());
            }
        }
    }
}
