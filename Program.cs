using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("1 - Resultado da soma");
        ExibirResultadoSoma();

        Console.WriteLine("\n2 - Proximo elemento");
        ExibirResultadoSequencias();

        Console.WriteLine("\n 3 - Dados de Faturamento");
        double[] faturamento = new double[365];

        faturamento[0] = 7710;
        faturamento[1] = 2985;
        faturamento[2] = 0; 
        faturamento[3] = 0;
        faturamento[4] = 0; 
        faturamento[5] = 4200;
        faturamento[6] = 29865;
        faturamento[7] = 97789; 

        ExibirDadosDeFaturamento(faturamento);
    }

    public static void ExibirDadosDeFaturamento(double[] faturamento)
    {
        var resultado = CalcularFaturamento(faturamento);

        Console.WriteLine($"Menor faturamento: {resultado.Menor:F2}");
        Console.WriteLine($"Maior  faturamento: {resultado.Maior:F2}");
        Console.WriteLine($"Dias acima da media: {resultado.DiasAcimaDaMedia}");
    }

    public static (double Menor, double Maior, int DiasAcimaDaMedia) CalcularFaturamento(double[] faturamento)
    {
        var diasComFaturamento = faturamento.Where(x => x > 0).ToArray();

        if (diasComFaturamento.Length == 0)
        {
            return (0, 0, 0);
        }

        double menor = diasComFaturamento.Min();
        double maior = diasComFaturamento.Max();

        double media = diasComFaturamento.Average();

        int diasAcimaDaMedia = diasComFaturamento.Count(x => x > media);

        return (menor, maior, diasAcimaDaMedia);
    }

    static void ExibirResultadoSequencias()
    {
        Console.WriteLine("sequencia a: 1, 3, 5, 7, ___");
        Console.WriteLine("Proximo elemento: " + ProximoElementoA());

        Console.WriteLine("\nsequencia b: 2, 4, 8, 16, 32, 64, ____");
        Console.WriteLine("Proximo elemento: " + ProximoElementoB());

        Console.WriteLine("\nsequencia c: 0, 1, 4, 9, 16, 25, 36, ____");
        Console.WriteLine("Próximo elemento: " + ProximoElementoC());

        Console.WriteLine("\nsequencia d: 4, 16, 36, 64, ____");
        Console.WriteLine("Proximo elemento: " + ProximoElementoD());

        Console.WriteLine("\nsequencia e: 1, 1, 2, 3, 5, 8, ____");
        Console.WriteLine("Proximo elemento: " + ProximoElementoE());

        Console.WriteLine("\nsequencia f: 2, 10, 12, 16, 17, 18, 19, ____");
        Console.WriteLine("Proximo elemento: " + ProximoElementoF());
    }

    static void ExibirResultadoSoma()
    {
        int resultado = Soma();
        Console.WriteLine("\nResultado da soma:");
        Console.WriteLine("Resultado final: " + resultado);
    }

    static int ProximoElementoA()
    {
        int ultimo = 7;
        return ultimo + 2;
    }

    static int ProximoElementoB()
    {
        int[] sequencia = { 2, 4, 8, 16, 32, 64 };
        return sequencia[sequencia.Length - 1] * 2;
    }

    static int ProximoElementoC()
    {
        int proximoNumero = 7; 
        return proximoNumero * proximoNumero;
    }

    static int ProximoElementoD()
    {
        int[] sequencia = { 4, 16, 36, 64 };
        int proximoIndice = (int)Math.Sqrt(sequencia[sequencia.Length - 1]) + 2;
        return proximoIndice * proximoIndice;
    }

    static int ProximoElementoE()
    {
        int a = 1;
        int b = 1; 
        int c;
        for (int i = 2; i < 7; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return b;
    }

    static int ProximoElementoF()
    {
        int[] sequencia = { 2, 10, 12, 16, 17, 18, 19 };
        return sequencia[sequencia.Length - 1] + 1;
    }

    static int Soma()
    {
        int indice = 12;
        int soma = 0;
        int k = 1;

        while (k < indice)
        {
            k = k + 1;
            soma += k;
            Console.WriteLine(soma);
        }
        return soma;
    }
}
