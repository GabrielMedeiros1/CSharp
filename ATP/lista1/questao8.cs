using System;
class Program
{
    static void Main(string[] args)
    {
        /*QUESTÃO 8: Faça um programa para ler uma conta corrente(sempre com 3 digítos) e imprimir seu 
        dígito verificador que é calculado da seguinte maneira
        a) Some o número da conta com seu inverso(CDU+UDC);
        b) Multiplicar cada dígito da soma por sua posição, sendo que a posição das centenas é 1, das dezenas é 2 e das unidades 3;
        c) Somar cada uma das multiplicações;
        d) O dígito verificador é o último dígito da soma anterior. */

        int contaCorrente, contaInv, soma, c, d, u, mult1, digitoVerificador, mult2, mult3, somatotal;
        //entrada de dados
        Console.WriteLine("Digite os 3 dígitos da sua conta corrente: ");
        contaCorrente = int.Parse(Console.ReadLine());

        //cálculo para achar o número inverso
        c = contaCorrente / 100;
        d = (contaCorrente % 100) / 10;
        u = contaCorrente % 10;
        contaInv = u * 100 + d * 10 + c;

        //cálculo para achar o dígito verificador
        soma = contaCorrente + contaInv;
        mult1 = c * soma;
        mult2 = d * soma;
        mult3 = u * soma;
        somatotal = mult1 + mult2 + mult3;
        digitoVerificador = somatotal % 10;

        //saída do resultado
        Console.WriteLine("O dígito verificador da sua conta corrente é: " + digitoVerificador);
    }
}
