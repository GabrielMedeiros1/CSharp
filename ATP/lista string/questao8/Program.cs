using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Informe a quantidade de veículos da locadora: ");
        int quantidadeVeiculos = int.Parse(Console.ReadLine());

        Console.Write("Informe o valor do aluguel por veículo: ");
        double valorAluguel = double.Parse(Console.ReadLine());

        //chama as funções para fazer os cálculos
        double faturamentoAnual = CalcularFaturamentoAnual(quantidadeVeiculos, valorAluguel);
        double valorMultasMensal = CalcularValorMultasMensal(quantidadeVeiculos, valorAluguel);
        double valorManutencaoAnual = CalcularValorManutencaoAnual(quantidadeVeiculos); 

        Console.WriteLine("Faturamento Anual: R$" + faturamentoAnual);
        Console.WriteLine("Valor das Multas no Mês: R$" + valorMultasMensal);
        Console.WriteLine("Valor da Manutenção Anual: R$" + valorManutencaoAnual);

        GravarResultadoEmArquivo(faturamentoAnual, valorMultasMensal, valorManutencaoAnual);

        Console.WriteLine("Resultados gravados no arquivo resultado.txt.");
    }

    static double CalcularFaturamentoAnual(int quantidadeVeiculos, double valorAluguel) //calcula o faturamento anual
    {
        int veiculosAlugadosPorMes = quantidadeVeiculos / 3;
        int mesesNoAno = 12;
        return veiculosAlugadosPorMes * valorAluguel * mesesNoAno;
    }

    static double CalcularValorMultasMensal(int quantidadeVeiculos, double valorAluguel) //calcula o valor mensal das multas
    {
        int veiculosDevolvidosAtrasoPorMes = quantidadeVeiculos / 10;
        double percentualMulta = 0.2;
        return veiculosDevolvidosAtrasoPorMes * valorAluguel * percentualMulta;
    }

    static double CalcularValorManutencaoAnual(int quantidadeVeiculos) //calcula o valor da manuntenção anual
    {
        double percentualManutencao = 0.02;
        double valorManutencaoMedia = 600.00;
        return quantidadeVeiculos * percentualManutencao * valorManutencaoMedia;
    }

    static void GravarResultadoEmArquivo(double faturamentoAnual, double valorMultasMensal, double valorManutencaoAnual)
    {
        using (StreamWriter writer = new StreamWriter("resultado.txt")) //saída do resultado
        {
            writer.WriteLine(faturamentoAnual);
            writer.WriteLine(valorMultasMensal);
            writer.WriteLine(valorManutencaoAnual);
        }
    }
}