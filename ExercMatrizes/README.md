# Exercícios efetuados durante o aprendizado em Linguagem C#
Exercícios de Fixação sobre os seguintes tópicos:
- Vetores

# Dependencias
#### .NET Core Framework 3.0
#### Biblioteca "using System;"
#### Biblioteca "using System.Globalization;"
#### Biblioteca "using System.Collections.Generic;"

### Execícios
#### 1 - Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas contendo números inteiros,
podendo haver repetições. Em seguida, ler um número inteiro X que pertence à matriz. Para cada ocorrência de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver, conforme exemplo.
´´´
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
´´´