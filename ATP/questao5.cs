using System;

class Program {
    static void Main(string[] args){
        //QUESTÃO 5. Uma pessoa resolveu fazer uma aplicação em uma poupança programada em que o valor acumulado é igual a p*((1+i)^n -1)/i, onde p é a aplicação mensal,
        //i é a taxa e n é o número de meses. Faça um programa para ler o valor constante da aplicação mensal, a taxa e o número de meses, calcular e msotrar o rendimento.
        
        // entrada de dados 
            double p; double i; double valorAcumulado;int n; 

            Console.Write("Digite o valor da aplicação mensal: ");
            p = double.Parse(Console.ReadLine());
            Console.Write("Digite a taxa de juros mensal (em decimal): ");
            i = double.Parse(Console.ReadLine());
            Console.Write("Digite o número de meses da aplicação: ");
            n = int.Parse(Console.ReadLine());

            // cálculo do valor acumulado na poupança
            valorAcumulado = p * ((Math.Pow(1 + i, n) - 1))/i;

            // saída do resultado
            Console.WriteLine("O valor acumulado na poupança é: R$ {0:F2}", valorAcumulado);
    }
}
