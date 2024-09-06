using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

public class Program
{
    static void Main()
    {
        int resultado = Soma();

        Console.WriteLine("Resultado final: " + resultado);
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
