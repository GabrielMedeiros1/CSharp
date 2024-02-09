using System;
class Program{
    static void Main(string[]args){
        //QUESTÃO 3. Sabendo que 100 kilowatt de energia custa um sétimo do salário mínimo,
        //faça um programa para ler o valor do salário mínimo e a quantidade de kilowatt gasta
        //em uma residência, calcular e mostrar: o valor em reais de cada kilowatt; o valor em reais a ser pago;
        //e o novo valor a ser pago por essa residência com um desconto de 10%.
    
        double salarioMinimo; double qtdKilowatt; double valorKilowatt; double valorComDesconto; double valorTotal;

        Console.Write("Digite o valor do salário mínimo: R$ ");
        salarioMinimo = double.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade de kilowatt gasta: ");
        qtdKilowatt = double.Parse(Console.ReadLine());

        // cálculo do valor em reais de cada kilowatt
        valorKilowatt = salarioMinimo / (7 * 100);

        // cálculo do valor em reais a ser pago sem desconto
        valorTotal = qtdKilowatt * valorKilowatt;

        // cálculo do valor em reais a ser pago com desconto de 10%
        valorComDesconto = valorTotal * 0.9;

        // impressão dos resultados
        Console.WriteLine("Valor em reais de cada kilowatt: R$ " + valorKilowatt.ToString("F2"));
        Console.WriteLine("Valor Total em reais a ser pago: R$ " + valorTotal.ToString("F2"));
        Console.WriteLine("Valor em reais a ser pago com desconto de 10%: R$ " + valorComDesconto.ToString("F2"));
    }
}
