using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        int contadorEspacos = ContarEspacos(frase);

        Console.WriteLine($"A frase possui {contadorEspacos} espaço(s) em branco.");
    }

    static int ContarEspacos(string frase)
    {
        int contador = 0;
        foreach (char caractere in frase)
        {
            if (caractere == ' ')
            {
                contador++;
            }
        }
        return contador;
    }
}