using System;
class Program{
    static void Main(string[]args){
        //QUESTÃO 4. Construa um algoritmo que, tendo como dados de entrada dois pontos quaisquer no plano, P(x1,y1) e P(x2,y2), escreva a distância entre eles.
        double x1,x2,y1,y2,distancia;
        //entrada de dados do usuário
        Console.WriteLine("Digite os pontos P1(x1,y1) e P2(x2,y2): ");
        x1 = double.Parse(Console.ReadLine());
        y1 = double.Parse(Console.ReadLine());
        x2 = double.Parse(Console.ReadLine());
        y2 = double.Parse(Console.ReadLine());

        //cálculo da distância dos pontos no plano
        distancia = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
        //saída do resultado
        Console.WriteLine("A distância entre os pontos P1 e P2 é igual a: "+distancia.ToString("F2"));
    }
}
