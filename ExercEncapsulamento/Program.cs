using System;
using System.Globalization;

namespace ExercEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do títular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial ? (s/n): ");
            char depIniSouN = Char.Parse(Console.ReadLine());

            ContaBancaria cb = new ContaBancaria(numero, titular);

            if (depIniSouN == 's')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb = new ContaBancaria(numero, titular, saldo);
            }

            Console.WriteLine("");

            Console.WriteLine(cb);

            Console.WriteLine("");

            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cb);

            Console.WriteLine("");

            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cb);

        }
    }
}
