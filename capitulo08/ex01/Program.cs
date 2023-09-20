namespace ex01
{
    public class Heroi
    {
        int forca;
        int life;
        int moedas;
        int tipoDeHeroi;

        public Heroi(int f, int l, int m, int t)
        {
            forca = f;
            life = l;
            moedas = m;
            tipoDeHeroi = t;
        }

        public void Atacar()
        {
            if (tipoDeHeroi == 1)
            {
                Console.WriteLine("Ataque com espada");
            }
            else
            {
                Console.WriteLine("Ataque com magia");
            }
        }

        public void SofrerDano(int dano)
        {
            life -= dano;
            if (life <= 0)
            {
                Console.WriteLine("O herói morreu");
            }
        }

        public class Dragao
        {
            int mordida;
            int bolaFogo;
            int life;
            int recompensa;

            public Dragao(int m, int b, int l, int r)
            {
                mordida = m;
                bolaFogo = b;
                life = l;
                recompensa = r;
            }

            public void Morder()
            {
                Console.WriteLine("Mordida");
            }

            public void LancarFogo()
            {
                Console.WriteLine("Lançar bola de fogo");
            }

            public void SofrerDano(int dano)
            {
                life -= dano;
                if (life <= 0)
                    Console.WriteLine("Dragão derrotado");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                //Criação dos objetos
                Heroi Cavaleiro = new Heroi(80, 100, 0, 1);
                Heroi Mago = new Heroi(60, 100, 0, 2);
                Dragao DragaoVermelho = new Dragao(70, 110, 100, 30);
                //Cavaleiro ataca Dragão
                Cavaleiro.Atacar();
                //Dragão sofre dano do Cavaleiro
                DragaoVermelho.SofrerDano(80);
                //Dragão ataca Cavaleiro
                DragaoVermelho.LancarFogo();
                //Cavaleiro sofre dano do Dragão (morre)
                Cavaleiro.SofrerDano(110);
                //Mago ataca Dragão
                Mago.Atacar();
                //Dragão sofre dano do Mago (morre)
                DragaoVermelho.SofrerDano(60);
            }
        }
    }
}
