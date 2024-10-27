using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Informe a quantidade de letras (N): ");
        int quantidadeLetras = int.Parse(Console.ReadLine());

        string letras = ObterLetras(quantidadeLetras);

        SalvarLetrasEmArquivo(letras);

        int quantidadeVogais = ContarVogais(letras);

        Console.WriteLine("Quantidade de vogais no arquivo: " + quantidadeVogais);
    }

    static string ObterLetras(int quantidade)
    {
        string letras = "";
        for (int i = 1; i <= quantidade; i++)
        {
            Console.Write("Informe a letra #" + i + ": ");
            char letra = Console.ReadLine()[0];
            letras += letra;
        }
        return letras;
    }

    static void SalvarLetrasEmArquivo(string letras)
    {
        using (StreamWriter writer = new StreamWriter("letras.txt"))
        {
            writer.WriteLine(letras);
        }
    }

    static int ContarVogais(string letras)
    {
        int quantidadeVogais = 0;
        foreach (char letra in letras.ToLower())
        {
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                quantidadeVogais++;
            }
        }
        return quantidadeVogais;
    }
}