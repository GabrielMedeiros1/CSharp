using System;

class Program{
    public static void Main(string[]args){
        int t = int.Parse(Console.ReadLine()); //quantidade de triângulos que serão informados

        for(int i = 0; i<t; i++){
            //entrada de dados
            string linha = Console.ReadLine();
            string [] valores = linha.Split(' ');

            double v1 = double.Parse(valores[0]);
            double v2 = double.Parse(valores[1]);
            double v3 = double.Parse(valores[2]);

            double a = 0,b = 0;//encontra o maior lado

            double maiorValor = AcharMaiorValor(v1,v2,v3,a,b);

                //verificando se é possível existir um triângulo com os valores informados
                if(v1 + v2 > v3 && v1 + v3 > v2 && v2 + v3 > v1){ 
                    if(maiorValor*maiorValor == a*a + b*b){
                            Console.WriteLine("r"); //é um triângulo retângulo
                        }
                        else if(maiorValor*maiorValor < a*a + b*b){
                            Console.WriteLine("a"); //é um triângulo acutângulo
                            }
                        else{
                            Console.WriteLine("o"); //é um triângulo obstusângulo
                            }
                        }
                else{
                    Console.WriteLine("n"); //não é possível formar um triângulo com os valores informados
                }
        }
    }

    static double AcharMaiorValor(double v1, double v2, double v3, double a, double b){
        double maiorValor;

        if(v1>v2 && v1>v3){
                maiorValor = v1;
                a = v2;
                b = v3;
            }else if(v2>v1 && v2>v3){
                maiorValor = v2;
                a = v1;
                b = v3;
                
            }else{
                maiorValor = v3;
                a = v1;
                b = v2;
            }
            return maiorValor;
    }
}