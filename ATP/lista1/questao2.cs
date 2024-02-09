using System;
class Program{
    static void Main(string[]args){
        //QUESTÃO 2. Faça um programa para ler os valores dos catetos de um triângulo retângulo e mostrar a hipotenusa;
        
        double cateto1, cateto2, hipotenusa;

        //entrada de dados do usuário
        Console.WriteLine("Digite os valores dos catetos do triângulo retângulo: ");
        cateto1 = double.Parse(Console.ReadLine());
        cateto2 = double.Parse(Console.ReadLine());

        //cálculo da hipotenusa
        hipotenusa = Math.Sqrt((cateto1*cateto1)+(cateto2*cateto2));

        //saída do resultado
        Console.WriteLine("O valor da hipotenusa é igual a: {0:F2}",hipotenusa);
    }
}
