namespace TAD
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;
        private string genero;

        // Construtor
        public Pessoa(string nome, string sobrenome, string genero)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.genero = genero;
        }

        // Getters e Setters para Nome
        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        // Getters e Setters para Sobrenome
        public string GetSobrenome()
        {
            return sobrenome;
        }

        public void SetSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        // Getters e Setters para Genero
        public string GetGenero()
        {
            return genero;
        }

        public void SetGenero(string genero)
        {
            this.genero = genero;
        }

        public override string ToString()
        {
            return $"{nome} {sobrenome}, Gênero: {genero}";
        }
    }
}
