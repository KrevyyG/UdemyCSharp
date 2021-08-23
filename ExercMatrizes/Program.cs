using System;

namespace ExercMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = Console.ReadLine().Split(' ');
            int m = int.Parse(vect[0]);
            int n = int.Parse(vect[1]);

            int[,] mat = new int[m,n];

            for (int i = 0; i< m; i++)
            {
                vect = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(vect[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Posição: " + i + ", " + j);

                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, (j - 1)]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Cima: " + mat[(i - 1), j]);
                        }

                        if ((j + 1) < n)
                        {
                            Console.WriteLine("Direita: " + mat[i, (j + 1)]);
                        }

                        if ((i + 1) < m)
                        {
                            Console.WriteLine("Baixo: " + mat[(i + 1), j]);
                        }

                    }
                }
            }

        }
    }
}
