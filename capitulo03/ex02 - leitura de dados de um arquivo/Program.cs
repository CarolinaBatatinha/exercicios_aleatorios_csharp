string caminhoArquivo = "D:\\SENAC\\2 - periodo2\\Algoritmos e Programação II\\exercícios\\capitulo03 - manipulacao de arquivos\\ex02\\arquivo.txt";

using (StreamReader leitor = new StreamReader(caminhoArquivo))
{
    //aqui os dados do arquivo são lidos usando o objeto 'leitor'
    string linha;
    while ((linha = leitor.ReadLine()) != null)
    {
        Console.WriteLine(linha); // exibe a linha lida
    }
}