# Exercícios efetuados durante o aprendizado em Linguagem C#
Exercícios de Fixação sobre os seguintes tópicos:
- Estrurura Repetitiva (for)

# Dependencias
#### .NET Core Framework 3.0
#### Biblioteca "using System;"
#### Biblioteca "using System.Globalization;"
#### Biblioteca "using System.Collections.Generic;"

### Execícios
#### 1 - Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
´´´
                Console.Write("Digite um número inteiro: ");
                int nr = int.Parse(Console.ReadLine());

                for (int i = 1; i <= nr; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
´´´

#### 2 - Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
´´´
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
´´´

#### 3 - Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
´´´
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
´´´

#### 4 - Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
´´´
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
´´´

#### 5 - Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1. Lembrando que, por definição, fatorial de 0 é 1.
´´´
                Console.Write("Digite um número inteiro: ");
                int n = int.Parse(Console.ReadLine());

                int fat = 1;
                for (int i = 1; i <= n; i++)
                {
                    fat = fat * i;
                }
                
                Console.WriteLine(fat);                  
´´´

#### 6 - Ler um número inteiro N e calcular todos os seus divisores.
´´´
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
´´´

#### 7 - Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.
´´´
                Console.Write("Digite um número inteiro: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    int quad = i * i;
                    int cubo = (i * i) * i;
                    Console.WriteLine("{0} {1} {2}", i, quad, cubo);
                }                      
´´´