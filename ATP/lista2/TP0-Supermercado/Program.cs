using System;

class Program{
    public static void Main(string[]args){
        int N, G, i;
        double P, menor = 999999;
        string linha;
        string [] valores;

        N = int.Parse(Console.ReadLine());

        for(i=1; i<= N; i++){
            linha = Console.ReadLine();
            valores = linha.Split(' ');
            P = double.Parse(valores[0]);
            G = int.Parse(valores[1]);
            P = P/G *1000;

            if(P<menor){
                menor = P;
            }
        }
        Console.WriteLine("{0:0.00}", menor);
    }
}