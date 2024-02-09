using System;
class Program{
    static void Main(string[]args){
        //QUESTÃO 1. Faça um programa para ler a base e a altura de um retângulo e mostrar seu perímetro, área e diagonal.
        
        //entrada de dados
        double b, a, area, perimetro, diagonal;

        Console.WriteLine("Digite a base e a altura do retângulo: ");
        b = double.Parse(Console.ReadLine());
        a = double.Parse(Console.ReadLine());

        //cálculos da área, perímetro e diagonal do retângulo
        area = b*a;
        perimetro = 2*(b+a);
        diagonal = Math.Sqrt((b*b)+(a*a));

        //saída de dados
        Console.WriteLine("O perímetro do retângulo é igual a: " + perimetro +"\nA área é igual a: " + area +"\nA diagonal é igual a: "+diagonal);
    }
}
