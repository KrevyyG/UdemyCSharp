# Exercícios efetuados durante o aprendizado em Linguagem C#
Exercícios de Fixação sobre os seguintes tópicos:
- Estrurura Sequencial (if-else)

# Dependencias
#### .NET Core Framework 3.0
#### Biblioteca "using System;"
#### Biblioteca "using System.Globalization;"
#### Biblioteca "using System.Collections.Generic;"

### Execícios
#### 1 - Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
´´´
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
´´´

#### 2 - Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
´´´
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
´´´

#### 3 - Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.
´´´
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
´´´

#### 4 - Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas
´´´
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
´´´

#### 5 - Com base na tabela disponibilizada, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.
´´´
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
´´´

#### 6 - Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25 50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
´´´
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
´´´

#### 7 - Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0). Se o ponto estiver na origem, escreva a mensagem “Origem”. Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.
´´´
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
´´´

#### 8 - Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$. 
#### Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
#### Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas decimais.
´´´
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
´´´