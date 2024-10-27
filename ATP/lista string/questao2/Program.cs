using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string fraseSemVogais = RemoverVogais(frase);

        Console.WriteLine("Frase sem vogais: {0}", fraseSemVogais);
    }

    static string RemoverVogais(string frase)
    {
        string vogais = "aeiouAEIOU";
        string novaFrase = "";

        foreach (char caractere in frase) //verifica onde está as vogais na frase
        {
            if (!vogais.Contains(caractere))
            {
                novaFrase += caractere;
            }
        }

        return novaFrase;
    }
}