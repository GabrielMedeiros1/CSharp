using System;

class Program{
    public static void Main(string[]args){
        //entrada de dados
        string entrada = Console.ReadLine();
        string [] numeros = entrada.Split(' ');

        int m = int.Parse(numeros[0]);
        int n = int.Parse(numeros[1]);

        int [,] matriz = new int [m,n];

        //inicializando a matriz
        for(int i = 0; i < m; i++){
            string[]valores = Console.ReadLine().Split(' ');
            for(int j = 0; j < n; j++){
                matriz[i,j] = int.Parse(valores[j]);
            }
        }

        bool simetria = verificarSimetria(matriz, m, n); //chama função que verifica se a matriz é simétrica ou não

        //exibe o resultado
        if(simetria){ 
            Console.WriteLine("1");
        }else{
            Console.WriteLine("0");
        }
    }

    static bool verificarSimetria(int[,]matriz,int m, int n){
        if(m!=n){
            return false; //matriz não é quadrada
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (matriz[i, j] != matriz[j, i])
                {
                    return false;
                }
            }
        }

        return true;
    }
}
