using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercEstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite qual o número do exercício a ser testado de 1 a 8: ");
            int nrExerc = int.Parse(Console.ReadLine());
            Console.Clear();

            if (nrExerc == 1)
            {
                Console.WriteLine("Exercício 1");
                Console.Write("Digite um Número Inteiro: ");
                int n1 = int.Parse(Console.ReadLine());
                if (n1 < 0)
                {
                    Console.WriteLine(n1 + " é um valor negativo");
                }
                else
                {                                                
                    Console.WriteLine(n1 + " é um valor positivo");
                }
            }
            else if (nrExerc == 2)
            {
                Console.WriteLine("Exercício 2");
                Console.Write("Digite um Número Inteiro: ");
                int n1 = int.Parse(Console.ReadLine());
                if (n1 % 2 == 0)
                {
                    Console.WriteLine(n1 + " é um número par");
                }
                else
                {
                    Console.WriteLine(n1 + " é um número ímpar");
                }

            }
            else if (nrExerc == 3)
            {
                Console.WriteLine("Exercício 3");
                Console.Write("Digite um Número Inteiro: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Digite outro Número Inteiro: ");
                int b = int.Parse(Console.ReadLine());
                if (a % b == 0 || b % a == 0)
                {
                    Console.WriteLine("Númros digitados são multiplos");
                }
                else
                {
                    Console.WriteLine("Númros digitados não são multiplos");
                }
            }
            else if (nrExerc == 4)
            {
                Console.WriteLine("Exercício 4");
                Console.Write("Digite a Hora inicial do jogo: ");
                int hrIni = int.Parse(Console.ReadLine());
                Console.Write("Digite a Hora final do jogo: ");
                int hrFim = int.Parse(Console.ReadLine());
                if (hrIni < hrFim)
                {
                    int duracao = hrFim - hrIni;
                    Console.WriteLine("Duração do Jogo foi de: " + duracao + " horas");
                }
                else
                {
                    int duracao = 24 - hrIni + hrFim;
                    Console.WriteLine("Duração do Jogo foi de: " + duracao + " horas");
                }

            }
            else if (nrExerc == 5)
            {
                Console.WriteLine("Exercício 5");
                Console.Write("Digite o código do item: ");
                int codItem = int.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade do item: ");
                int qtdeItem = int.Parse(Console.ReadLine());
                if (codItem == 1)
                {
                    Console.WriteLine(qtdeItem + " Unidades de Cachorro Quente");
                    float vlrPagar = qtdeItem * 4.0f;
                    Console.WriteLine("Valor a pagar: R$" + vlrPagar.ToString("F2"));
                }
                else if (codItem == 2)
                {
                    Console.WriteLine(qtdeItem + " Unidades de X-Salada");
                    float vlrPagar = qtdeItem * 4.5f;
                    Console.WriteLine("Valor a pagar: R$" + vlrPagar.ToString("F2"));
                }
                else if (codItem == 3)
                {
                    Console.WriteLine(qtdeItem + " Unidades de X-Bacon");
                    float vlrPagar = qtdeItem * 5.0f;
                    Console.WriteLine("Valor a pagar: R$" + vlrPagar.ToString("F2"));
                }
                else if (codItem == 4)
                {
                    Console.WriteLine(qtdeItem + " Unidades de Torrada Simples");
                    float vlrPagar = qtdeItem * 2.0f;
                    Console.WriteLine("Valor a pagar: R$" + vlrPagar.ToString("F2"));
                }
                else
                {
                    Console.WriteLine(qtdeItem + " Unidades de Refrigerante");
                    float vlrPagar = qtdeItem * 1.5f;
                    Console.WriteLine("Valor a pagar: R$" + vlrPagar.ToString("F2"));
                }
            }
            else if (nrExerc == 6)
            {
                Console.WriteLine("Exercício 6");
                Console.Write("Digite um valor float entre 0 e 100: ");
                float vlr = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (vlr >= 0 && vlr <= 25)
                {
                    Console.WriteLine("Valor digitado se encontra entre 0 e 25");
                }
                else if (vlr > 25 && vlr <= 50)
                {
                    Console.WriteLine("Valor digitado se encontra entre 25 e 50");
                }
                else if (vlr > 50 && vlr <= 75)
                {
                    Console.WriteLine("Valor digitado se encontra entre 50 e 75");
                }
                else if (vlr > 75 && vlr <= 100)
                {
                    Console.WriteLine("Valor digitado se encontra entre 75 e 100");
                }
                else 
                {
                    Console.WriteLine("Valor digitado não se encontra em nenhum intervalo");
                }

            }
            else if (nrExerc == 7)
            {
                Console.WriteLine("Exercício 7");
                Console.Write("Digite dois números flutuantes (na mesma linha): ");
                string[] vlrs = Console.ReadLine().Split(' ');
                double x = double.Parse(vlrs[0], CultureInfo.InvariantCulture);
                double y = double.Parse(vlrs[1], CultureInfo.InvariantCulture);
                if (x == 0.0 && y == 0.0)
                {
                    Console.WriteLine("Origem");
                }
                else if (x == 0.0)
                {
                    Console.WriteLine("Eixo Y");
                }
                else if (y == 0.0)
                {
                    Console.WriteLine("Eixo X");
                }
                else if (x > 0.0 && y > 0.0)
                {
                    Console.WriteLine("Q1");
                }
                else if (x < 0.0 && y > 0.0)
                {
                    Console.WriteLine("Q2");
                }
                else if (x < 0.0 && y < 0.0)
                {
                    Console.WriteLine("Q3");
                }
                else
                {
                    Console.WriteLine("Q4");
                }
            }
            else
            {
                Console.WriteLine("Exercício 8");
                Console.Write("Digite o valor do salário com duas casas decimais: R$");
                double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double imp = 0.0;
                if (sal <= 2000)
                {
                    Console.WriteLine("Isento de Imposto de Renda");
                }
                else if (sal <= 3000)
                {
                    imp = (sal - 2000.0f) * 0.08;
                    Console.WriteLine("O valor do imposto de renda a pagar é de R$" + imp.ToString("F2"));
                }
                else if (sal >= 3000.01 && sal <= 4500)
                {
                    imp = (sal - 3000.0) * 0.18 + 1000.0 * 0.08;
                    Console.WriteLine("O valor do imposto de renda a pagar é de R$" + imp.ToString("F2"));
                }
                else
                {
                    imp = (sal - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                    Console.WriteLine("O valor do imposto de renda a pagar é de R$" + imp.ToString("F2"));
                }
            }
        }
    }
}
