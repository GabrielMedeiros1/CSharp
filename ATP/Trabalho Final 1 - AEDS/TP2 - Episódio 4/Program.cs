using System;

class Program{
    public static void Main(string[]args){
        int qtdPersonagens;
        qtdPersonagens = int.Parse(Console.ReadLine()); //leitura da quantidade de personagens que serão informados
        Personagem[] personagens = new Personagem[qtdPersonagens];
        
        for(int i = 0; i < qtdPersonagens; i++){
            //entrada de dados dos personagens
            string[] atributos = Console.ReadLine().Split(';');
            personagens[i] = new Personagem();
            personagens[i].setNome(atributos[0]);
            personagens[i].setAltura(ConverterUnknownInt(atributos[1]));
            personagens[i].setPeso(ConverterUnknownDouble(atributos[2]));
            personagens[i].setCorDoCabelo(atributos[3]);
            personagens[i].setCorDaPele(atributos[4]);
            personagens[i].setCorDosOlhos(atributos[5]);
            personagens[i].setAnoNascimento(atributos[6]);
            personagens[i].setGenero(atributos[7]);
            personagens[i].setHomeworld(atributos[8]);
        }
        int qtdPesquisas = int.Parse(Console.ReadLine()); //quantas buscas serão feitas

        for (int i = 0; i < qtdPesquisas; i++)
        {
            string[] filtro = Console.ReadLine().Split(' ');
            
            switch (filtro[0])
            {
                case "nome":
                    string nome = string.Join(" ", filtro, 1, filtro.Length - 1);
                    int countNome = ContarPersonagensComNome(personagens, nome);
                    Console.WriteLine("nome " + countNome);
                    break;

                case "altura":
                    int alturaMin = int.Parse(filtro[1]);
                    int alturaMax = int.Parse(filtro[2]);
                    int countAltura = ContarPersonagensComAlturaDentroDoIntervalo(personagens, alturaMin, alturaMax);
                    Console.WriteLine("altura " + countAltura);
                    break;

                case "peso":
                    double pesoMin = double.Parse(filtro[1]);
                    double pesoMax = double.Parse(filtro[2]);
                    double countPeso = ContarPersonagensComPesoDentroDoIntervalo(personagens, pesoMin, pesoMax);
                    Console.WriteLine("peso " + countPeso);
                    break;

                case "corDoCabelo":
                    string corDoCabelo = string.Join(" ", filtro, 1, filtro.Length - 1);
                    int countCorDoCabelo = ContarPersonagensComCorDoCabelo(personagens, corDoCabelo);
                    Console.WriteLine("corDoCabelo " + countCorDoCabelo);
                    break;

                case "corDaPele":
                    string corDaPele = string.Join(" ", filtro, 1, filtro.Length - 1);
                    int countCorDaPele = ContarPersonagensComCorDaPele(personagens, corDaPele);
                    Console.WriteLine("corDaPele " + countCorDaPele);
                    break;

                case "corDosOlhos":
                    string corDosOlhos = string.Join(" ", filtro, 1, filtro.Length - 1);
                    int countCorDosOlhos = ContarPersonagensComCorDosOlhos(personagens, corDosOlhos);
                    Console.WriteLine("corDosOlhos " + countCorDosOlhos);
                    break;

                case "anoNascimento":
                    string anoNascimento = filtro[1];
                    int countAnoNascimento = ContarPersonagensComAnoNascimento(personagens, anoNascimento);
                    Console.WriteLine("anoNascimento " + countAnoNascimento);
                    break;

                case "genero":
                    string genero = filtro[1];
                    int countGenero = ContarPersonagensComGenero(personagens, genero);
                    Console.WriteLine("genero " + countGenero);
                    break;

                case "homeworld":
                     string homeworld = string.Join(" ", filtro, 1, filtro.Length - 1);
                     int countHomeworld = ContarPersonagensComHomeworld(personagens, homeworld);
                     Console.WriteLine("homeworld " + countHomeworld);
                    break;

                default:

                    break;
            }
        }
    }

//conferindo se o dado informado não está como "unknown"
      public static int ConverterUnknownInt(string valor)
    {
        if (valor == "unknown")
        {
            return 0;
        }
        return int.Parse(valor);
    }
     public static double ConverterUnknownDouble(string valor)
    {
        if (valor == "unknown")
        {
            return 0.0;
        }else{
        return double.Parse(valor);
        }
    }
    //conta personagens com nome
    public static int ContarPersonagensComNome(Personagem[] personagens, string nome)
{
    int count = 0;
    foreach (Personagem personagem in personagens)
    {
        if (personagem.getNome() == nome)
        {
            count++;
        }
    }
    return count;
}

    //conta personagens com a altura dentro do intervalo informado
    public static int ContarPersonagensComAlturaDentroDoIntervalo(Personagem[] personagens, double alturaMin, double alturaMax)
{
    int count = 0;
    foreach (Personagem personagem in personagens)
    {
        double altura = personagem.getAltura();
        if (altura >= alturaMin && altura <= alturaMax)
        {
            count++;
        }
    }
    return count;
}

//conta personagens com o peso dentro do intervalo informado
    public static int ContarPersonagensComPesoDentroDoIntervalo(Personagem[] personagens, double pesoMinimo, double pesoMaximo)
{
    int count = 0;
    foreach (Personagem personagem in personagens)
    {
        double peso = personagem.getPeso();
        if (pesoMinimo <= peso && peso <= pesoMaximo)
        {
            count++;
        }
    }
    return count;
}
//conta personagens com a cor do cabelo informada 
    public static int ContarPersonagensComCorDoCabelo(Personagem[] personagens, string corDoCabelo)
{
    int count = 0;
    foreach (Personagem personagem in personagens)
    {
        if (personagem.getCorDoCabelo() == corDoCabelo)
        {
            count++;
        }
    }
    return count;
}

//conta personagens com a cor da pele informada 
    public static int ContarPersonagensComCorDaPele(Personagem[] personagens, string corDaPele)
{
    int count = 0;
    foreach (Personagem personagem in personagens)
    {
        if (personagem.getCorDaPele() == corDaPele)
        {
            count++;
        }
    }
    return count;
}

//conta personagens com a cor dos olhos informada 
    public static int ContarPersonagensComCorDosOlhos(Personagem[] personagens, string corDosOlhos)
{
    int count = 0;
    foreach (Personagem personagem in personagens)
    {
        if (personagem.getCorDoCabelo() == corDosOlhos)
        {
            count++;
        }
    }
    return count;
}

//conta personagens com determinado ano de nascimento
    public static int ContarPersonagensComAnoNascimento(Personagem[] personagens, string anoNascimento)
{
    int count = 0;
    foreach (Personagem personagem in personagens)
    {
        if (personagem.getAnoNascimento() == anoNascimento)
        {
            count++;
        }
    }
    return count;
}

//conta personagens com determinado genero informado
    public static int ContarPersonagensComGenero(Personagem[] personagens, string genero)
{
    int count = 0;
    foreach (Personagem personagem in personagens)
    {
        if (personagem.getGenero() == genero)
        {
            count++;
        }
    }
    return count;
}

    public static int ContarPersonagensComHomeworld(Personagem[] personagens, string homeworld)
{
    int count = 0;
    foreach (Personagem personagem in personagens)
    {
        if (personagem.getHomeworld() == homeworld)
        {
            count++;
        }
    }
    return count;
}
}



class Personagem{
    private string nome, corDoCabelo, corDaPele, corDosOlhos, anoNascimento, genero, homeworld;
    private int altura;
    private double peso;

    public string getNome()
    {
        return nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public int getAltura()
    {
        return altura;
    }

    public void setAltura(int altura)
    {
        this.altura = altura;
    }

    public double getPeso()
    {
        return peso;
    }

    public void setPeso(double peso)
    {
        this.peso = peso;
    }

    public string getCorDoCabelo()
    {
        return corDoCabelo;
    }

    public void setCorDoCabelo(string corDoCabelo)
    {
        this.corDoCabelo = corDoCabelo;
    }

    public string getCorDaPele()
    {
        return corDaPele;
    }

    public void setCorDaPele(string corDaPele)
    {
        this.corDaPele = corDaPele;
    }

    public string getCorDosOlhos()
    {
        return corDosOlhos;
    }

    public void setCorDosOlhos(string corDosOlhos)
    {
        this.corDosOlhos = corDosOlhos;
    }

    public string getAnoNascimento()
    {
        return anoNascimento;
    }

    public void setAnoNascimento(string anoNascimento)
    {
        this.anoNascimento = anoNascimento;
    }

    public string getGenero()
    {
        return genero;
    }

    public void setGenero(string genero)
    {
        this.genero = genero;
    }

    public string getHomeworld()
    {
        return homeworld;
    }

    public void setHomeworld(string homeworld)
    {
        this.homeworld = homeworld;
    }
}