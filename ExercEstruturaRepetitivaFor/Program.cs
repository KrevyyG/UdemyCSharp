using System;
using System.Globalization;

namespace ExercEstruturaRepetitivaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite qual o número do exercício a ser testado de 1 a 7: ");
            int nrExerc = int.Parse(Console.ReadLine());
            Console.Clear();

            if (nrExerc == 1)
            {
                Console.Write("Digite um número inteiro: ");
                int nr = int.Parse(Console.ReadLine());

                for (int i = 1; i <= nr; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            else if (nrExerc == 2)
            {
                Console.Write("Digite um número inteiro: ");
                int N = int.Parse(Console.ReadLine());
                int In = 0;
                int Out = 0;

                for (int i = 1; i <= N; i++)
                {
                    Console.Write("Digite um valor: ");
                    int X = int.Parse(Console.ReadLine());
                    if (X >= 10 && X <= 20)
                    {
                        In++;
                    }
                    else
                    {
                        Out++;
                    }
                }

                Console.WriteLine("In {0}", In);
                Console.WriteLine("Out {0}", Out);
            }

            else if (nrExerc == 3)
            {
                Console.Write("Digite um número inteiro: ");
                int n = int.Parse(Console.ReadLine());
                

                for (int i = 1; i <= n; i++)
                {
                    Console.Write("Digite 3 valores decimais (na mesma linha): ");
                    string[] vlrs = Console.ReadLine().Split(' ');
                    double x = (double.Parse(vlrs[0], CultureInfo.InvariantCulture) * 2);
                    double y = (double.Parse(vlrs[1], CultureInfo.InvariantCulture) * 3);
                    double z = (double.Parse(vlrs[2], CultureInfo.InvariantCulture) * 5);

                    double media = ((x + y + z) / 10);
                    Console.WriteLine(media.ToString("F1"));
                }
            }

            else if (nrExerc == 4)
            {
                Console.Write("Digite um número inteiro: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.Write("Digite 2 valores decimais (na mesma linha): ");
                    string[] vlrs = Console.ReadLine().Split(' ');
                    double x = double.Parse(vlrs[0], CultureInfo.InvariantCulture);
                    double y = double.Parse(vlrs[1], CultureInfo.InvariantCulture);
                    if (y == 0)
                    {
                        Console.WriteLine("Divisão impossível");
                    }
                    else
                    {
                        double div = (x / y);
                        Console.WriteLine(div);
                    }
                    
                }
            }

            else if (nrExerc == 5)
            {
                Console.Write("Digite um número inteiro: ");
                int n = int.Parse(Console.ReadLine());

                int fat = 1;
                for (int i = 1; i <= n; i++)
                {
                    fat = fat * i;
                }
                
                Console.WriteLine(fat);

            }

            else if (nrExerc == 6)
            {
                Console.Write("Digite um número inteiro: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    int div = n % i;
                    if (div == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            else if (nrExerc == 7)
            {
                Console.Write("Digite um número inteiro: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    int quad = i * i;
                    int cubo = (i * i) * i;
                    Console.WriteLine("{0} {1} {2}", i, quad, cubo);
                }
            }
        }
    }
}
