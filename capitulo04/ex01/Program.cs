int[] dados = { 52, 17, 24, 12, 1, 7, 16, 2, 37 };
int valorProcurado = 17;
bool valorEncontrado = false;

// for (int i = 0; i < dados.Length; i++)
// {  
//     Array.Sort(dados);                       AQUI SERIA O MÉTODO UTILIZADO PARA ORDENAR OS VALORES DENTRO DO VETOR
//     Console.Write(dados[i] + "  ");   
// }

for (int i = 0; i < dados.Length; i++)
{
    if (dados[i] == valorProcurado) 
    {
        Console.WriteLine($"O valor {valorProcurado} foi encontrado no vetor.");
        valorEncontrado = true;
        break;
    }
}
    if (!valorEncontrado)
    {
        Console.WriteLine($"O valor {valorProcurado} não foi encontrado no vetor.");
    }
