using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o caminho completo do arquivo de texto:");
        string caminhoArquivo = Console.ReadLine();

        int quantidadeCaracteresA = ContarCaracteresA(caminhoArquivo);

        Console.WriteLine("Quantidade de caracteres 'a': {0}", quantidadeCaracteresA);
    }

    static int ContarCaracteresA(string caminhoArquivo)
    {
        int contador = 0;

        using (StreamReader reader = new StreamReader(caminhoArquivo))
        {
            string conteudo = reader.ReadToEnd(); //lê todo o conteúdo do arquivo

            foreach (char caractere in conteudo) //verifica cada caractere 
            {
                if (caractere == 'a' || caractere == 'A')
                {
                    contador++; //conta a quantidade de A's 
                }
            }
        }

        return contador;
    }
}