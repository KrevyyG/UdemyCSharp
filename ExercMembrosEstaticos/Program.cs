using System;
using System.Globalization;

namespace ExercMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtdeDol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.vlrDolar(cot, qtdeDol);

            Console.WriteLine("Valor a ser pago em Reais: " + result.ToString("F2", CultureInfo.InvariantCulture)) ;
        }
    }
}
