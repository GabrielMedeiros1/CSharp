using System;
class Program{
    static void Main(string[]args){
        //QUESTÃO 7. Faça um programa que leia quantidade de dias sem acidentes em uma empresa. Depois
        //apresente os dias sem acidentes separados em anos, meses e dias.
        //Considere que 1 ano tem 365 dias e um mês tem 30 dias
        //Exemplo:
        //Entrada: 400 dias. Saída: 1 ano, 1 mês e 5 dias.

        int totalDias; int dias; int meses; int ano;

        //entrada de dados
        Console.WriteLine("Digite a quantidade de dias sem acidentes na empresa: ");
        totalDias = int.Parse(Console.ReadLine());

        //cálculo para transformar dias em ANOS/MESES/DIAS
        ano = totalDias / 365;
        meses = (totalDias % 365) / 30;
        dias = (totalDias % 365) % 30;

        //saída do resultado
        Console.WriteLine("{0} ano(s), {1} mes(es) e {2} dia(s) sem acidentes.", ano,meses,dias);

    }
}
