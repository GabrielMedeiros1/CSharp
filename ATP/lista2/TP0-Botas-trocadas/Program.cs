using System;

class Program{
    public static void Main(string[]args){
        int [] botas = new int [61];
        int N, M, pares = 0;
        char L;
        string linha;
        string [] valores;

        for(int i = 0; i<61; i++){
            botas[i] = 0;
        }
            N = int.Parse(Console.ReadLine());
        
        for(int i=1; i<=N; i++){
            linha = Console.ReadLine();
            valores = linha.Split(' ');
            M = int.Parse(valores[0]);
            L = valores[1][0];

            if(L=='D'){
                if(botas[M] <0){
                    pares++;
                    botas[M]++;
                }else{
                    if(botas[M]>0)pares++;
                    botas[M]--;
                }
            }
        }
        Console.WriteLine("{0}",pares);
}
}