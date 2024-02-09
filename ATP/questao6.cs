using System;
class Program{
    static void Main(string[]args){
    //QUESTÃO 6.Faça um programa para ler dois números reais e salvá-los nas variáveis A e B, em seguida, efetuar a troca dos valores de forma que a variável A passe a ter o valor da variável B e vice-versa. No final, imprimir os valores finais.
    
    //entrada de dados
    double a; double b; double aux;

    Console.WriteLine("Digite os valores de A e B: ");
    a = double.Parse(Console.ReadLine());
    b = double.Parse(Console.ReadLine());

    //fazendo a troca
    aux=a;
    a=b;
    b=aux;
    
    //saída do resultado
    Console.WriteLine("Valor de A após a troca = "+a+"\nValor de B após a troca = " +b);

    }
}
