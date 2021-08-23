using System;

namespace ExercEstruturaRepetitivaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite qual o número do exercício a ser testado de 1 a 3: ");
            int nrExerc = int.Parse(Console.ReadLine());
            Console.Clear();

            if (nrExerc == 1)
            {
                Console.Write("Digite a senha: ");
                int senha = int.Parse(Console.ReadLine());

                while (senha != 2002)
                {
                    Console.WriteLine("Senha inválida!");
                    Console.Write("Digite uma senha válida: ");
                    senha = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Acesso permitido!");
            }

            else if (nrExerc == 2)
            {
                Console.Write("Digite dois números (na mesma linha): ");
                string[] vlrs = Console.ReadLine().Split(' ');
                int x = int.Parse(vlrs[0]);
                int y = int.Parse(vlrs[1]);

                while (x != 0 && y != 0)
                {
                    if (x > 0.0 && y > 0.0)
                    {
                        Console.WriteLine("Primeiro");
                    }
                    else if (x < 0.0 && y > 0.0)
                    {
                        Console.WriteLine("Segundo");
                    }
                    else if (x < 0.0 && y < 0.0)
                    {
                        Console.WriteLine("Terceiro");
                    }
                    else
                    {
                        Console.WriteLine("Quarto");
                    }

                    Console.Write("Digite dois números (na mesma linha): ");
                    vlrs = Console.ReadLine().Split(' ');
                    x = int.Parse(vlrs[0]);
                    y = int.Parse(vlrs[1]);
                }

            }

            else
            {
                Console.WriteLine("Códigos disponíveis: 1.Álcool 2.Gasolina 3.Diesel 4.Fim");
                Console.Write("Digite um código: ");
                int cod = int.Parse(Console.ReadLine());
                int cod1 = 0;
                int cod2 = 0;
                int cod3 = 0;

                while (cod != 4)
                {
                    if (cod == 1)
                    {
                        cod1++;
                    }
                    else if (cod == 2)
                    {
                        cod2++;
                    }
                    else if (cod == 3)
                    {
                        cod3++;
                    }
                    else
                    {
                        
                    }

                    Console.Write("Digite um código: ");
                    cod = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("MUITO OBRIGADO");
                Console.WriteLine("Álcool = " + cod1);
                Console.WriteLine("Gasolina = " + cod2);
                Console.WriteLine("Diesel = " + cod3);
            }
        }
    }
}

