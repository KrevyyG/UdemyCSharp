using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercExtruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Exercício 1");
            Console.Write("Digite o primeiro número da Soma: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número da Soma: ");
            int n2 = int.Parse(Console.ReadLine());
            int result1 = n1 + n2;
            Console.WriteLine("Resultado: " + result1);
            Console.WriteLine(" ");

            
            Console.WriteLine("Exercício 2");
            Console.Write("Digite o valor do raio do Círculo para o cálculo da área do mesmo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine("A = " + area.ToString("F4"));
            Console.WriteLine(" ");

            
            Console.WriteLine("Exercício 3");
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de D: ");
            int d = int.Parse(Console.ReadLine());
            int dif = (a * b) - (c * d);
            Console.WriteLine("A diferença entre os números é de: " + dif);
            Console.WriteLine(" ");

            
            Console.WriteLine("Exercício 4");
            Console.Write("Digite o número do Funcionário: ");
            int nrFunc = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de Horas trabalhadas: ");
            int hrsTrab = int.Parse(Console.ReadLine());
            Console.Write("Digite o Valor que recebe por hora trabalhada: ");
            double vlrHrs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = hrsTrab * vlrHrs;
            Console.WriteLine("Número do Funcionário: " + nrFunc);
            Console.WriteLine("Salário do Funcionário = U$" + salario.ToString("F2"));
            Console.WriteLine(" ");

            
            Console.WriteLine("Exercício 5");
            Console.WriteLine("Digite o código da primeira peça, quantidade de peças e valor unitário (Mesma Linha):");
            string[] vet1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet1[0]);
            int qtde1 = int.Parse(vet1[1]);
            float vlrUnit1 = float.Parse(vet1[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o código da segunda peça, quantidade de peças e valor unitário (Mesma Linha):");
            string[] vet2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet2[0]);
            int qtde2 = int.Parse(vet2[1]);
            float vlrUnit2 = float.Parse(vet2[2], CultureInfo.InvariantCulture);
            float vlrPagar = (qtde1 * vlrUnit1) + (qtde2 * vlrUnit2);
            Console.WriteLine("VALOR A PAGAR: R$"+ vlrPagar.ToString("F2"));
            Console.WriteLine(" ");

            
            Console.WriteLine("Exercício 6");
            Console.WriteLine("Digite 3 valores flutuantes (A, B e C): ");
            string[] vet3 = Console.ReadLine().Split(' ');
            double A = double.Parse(vet3[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet3[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet3[2], CultureInfo.InvariantCulture);
            double tri = (A * C) / 2;
            double circ = pi * Math.Pow(C, 2);
            double trap = ((A + B) * C) / 2;
            double quadr = Math.Pow(B, 2);
            double retan = A * B;
            Console.WriteLine("TRIANGULO: " + tri.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circ.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trap.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadr.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retan.ToString("F3"));
            Console.WriteLine(" ");
        }
    }
}
