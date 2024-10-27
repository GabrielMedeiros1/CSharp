using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o caminho completo do arquivo de texto:");
        string caminhoArquivo = Console.ReadLine();

        ImprimirConteudoArquivo(caminhoArquivo);
    }

    static void ImprimirConteudoArquivo(string caminhoArquivo)
    {
        try
        {
            int quantidadeLinhas = 0;

            using (StreamReader reader = new StreamReader(caminhoArquivo))
            {
                string linha;

                while ((linha = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                    quantidadeLinhas++; //conta a quantidade de linhas do arquivo
                }
            }

            Console.WriteLine("O arquivo possui {0} linha(s).",quantidadeLinhas);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
    }
}
