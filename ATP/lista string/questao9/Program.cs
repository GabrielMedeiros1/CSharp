using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("1 - Inserir dados de alunos");
        Console.WriteLine("2 - Ler dados de alunos");
        Console.WriteLine("0 - Sair");
        Console.WriteLine();

        int opcao;
        do
        {
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    InserirDadosAlunos();
                    break;
                case 2:
                    LerDadosAlunos();
                    break;
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
        while (opcao != 0);
    }

    static void InserirDadosAlunos()
    {
        Console.WriteLine("Inserindo dados de alunos...");
        Console.WriteLine();

        Console.Write("Informe a quantidade de alunos: ");
        int quantidadeAlunos = int.Parse(Console.ReadLine());

        using (StreamWriter writer = new StreamWriter("dados_alunos.txt", true))
        {
            for (int i = 1; i <= quantidadeAlunos; i++)
            {
                Console.Write("Informe a matrícula do aluno #" + i + ": ");
                string matricula = Console.ReadLine();

                Console.Write("Informe o telefone do aluno #" + i + ": ");
                string telefone = Console.ReadLine();

                writer.WriteLine(matricula + ";" + telefone);
            }
        }

        Console.WriteLine("Dados de alunos inseridos com sucesso!");
    }

    static void LerDadosAlunos()
    {
        Console.WriteLine("Lendo dados de alunos...");
        Console.WriteLine();

        if (File.Exists("dados_alunos.txt"))
        {
            using (StreamReader reader = new StreamReader("dados_alunos.txt"))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] dados = linha.Split(';');
                    string matricula = dados[0];
                    string telefone = dados[1];

                    Console.WriteLine("Matrícula: " + matricula);
                    Console.WriteLine("Telefone: " + telefone);
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine("Nenhum dado de aluno encontrado.");
        }
    }
}