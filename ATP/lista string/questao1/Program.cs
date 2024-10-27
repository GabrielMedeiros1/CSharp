using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        int contadorEspacos = ContarEspacos(frase);

        Console.WriteLine("A frase possui {0} espaço(s) em branco.", contadorEspacos);
    }

    static int ContarEspacos(string frase)
    {
        int contador = 0;
        foreach (char caractere in frase)//verifica se contém espaços em branco na frase
        {
            if (caractere == ' ')
            {
                contador++; //se tiver espaços, incrementa o contador
            }
        }
        return contador;
    }
}