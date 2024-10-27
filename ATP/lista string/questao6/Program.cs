using System;
using System.IO;

class Program
{
    static void Main(string[] args)
{
    Console.WriteLine("Digite um número inteiro:");
    int numero = int.Parse(Console.ReadLine());

    int somaDivisores = CalcularDivisores(numero);

    Console.WriteLine("Divisores:");
    ImprimirDivisores(numero);

    SalvarSomaDivisores(numero, somaDivisores);

    Console.WriteLine("Soma dos divisores salva no arquivo.");
}

static int CalcularDivisores(int numero)
{
    int soma = 0;

    // Percorre todos os números de 1 até o número dado
    for (int i = 1; i <= numero; i++)
    {
        // Verifica se o número é divisível por i
        if (numero % i == 0)
        {
            // Se for divisível, adiciona i à soma dos divisores
            soma += i;
        }
    }

    // Retorna a soma dos divisores
    return soma;
}

static void ImprimirDivisores(int numero)
{
    // Percorre todos os números de 1 até o número dado
    for (int i = 1; i <= numero; i++)
    {
        // Verifica se o número é divisível por i
        if (numero % i == 0)
        {
            // Se for divisível, imprime i na tela
            Console.WriteLine(i);
        }
    }
}

static void SalvarSomaDivisores(int numero, int somaDivisores)
{
    string nomeArquivo = "soma_divisores.txt";

    // Cria um objeto StreamWriter para escrever no arquivo
    using (StreamWriter writer = new StreamWriter(nomeArquivo))
    {
        // Escreve as informações no arquivo
        writer.WriteLine("Número: {0}",numero);
        writer.WriteLine("Soma dos divisores: {0}",somaDivisores);
    }
}
}