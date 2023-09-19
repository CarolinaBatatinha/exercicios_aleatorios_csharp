class Program
{
    static void Main(string[] args)
    {
        int[] vetor = { 5, 3, 1, 9, 7, 2, 4, 5, 8, 3 };

        Quick(vetor, 0, vetor.Length - 1);

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        static void Quick(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int pivo = Particionar(vetor, inicio, fim);
                Quick(vetor, inicio, pivo - 1);
                Quick(vetor, pivo + 1, fim);
            }
        }

        static int Particionar(int[] vetor, int inicio, int fim)
        {
            int esq = inicio;
            int dir = fim;
            int pivo = vetor[inicio];
            while (esq < dir)
            {
                while (esq <= fim && vetor[esq] <= pivo)
                {
                    esq++;
                }
                while (dir >= 0 && vetor[dir] > pivo)
                {
                    dir--;
                }
                if (esq < dir)
                {
                    int aux = vetor[esq];
                    vetor[esq] = vetor[dir];
                    vetor[dir] = aux;
                }
            }
            vetor[inicio] = vetor[dir];
            vetor[dir] = pivo;
            return dir;
        }
    }
}
