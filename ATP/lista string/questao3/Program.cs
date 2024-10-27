using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string fraseCodificada = CodificarCesar(frase, 3);

        Console.WriteLine($"Frase codificada: {fraseCodificada}");
    }

    static string CodificarCesar(string frase, int deslocamento)
    {
        string novaFrase = "";

        foreach (char caractere in frase)
        {
            if (char.IsLetter(caractere))
            {
                char caractereCodificado = (char)(caractere + deslocamento);

                if (!char.IsLetter(caractereCodificado))
                {
                    caractereCodificado = (char)(caractereCodificado - 26);
                }

                novaFrase += caractereCodificado;
            }
            else
            {
                novaFrase += caractere;
            }
        }

        return novaFrase;
    }
}