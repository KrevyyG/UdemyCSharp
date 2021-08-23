# Exercícios efetuados durante o aprendizado em Linguagem C#
Exercícios de Fixação sobre os seguintes tópicos:
- Estrurura Repetitiva (for)

# Dependencias
#### .NET Core Framework 3.0
#### Biblioteca "using System;"
#### Biblioteca "using System.Globalization;"
#### Biblioteca "using System.Collections.Generic;"

### Execícios
#### 1 - Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
´´´
                Console.Write("Digite a senha: ");
                int senha = int.Parse(Console.ReadLine());

                while (senha != 2002)
                {
                    Console.WriteLine("Senha inválida!");
                    Console.Write("Digite uma senha válida: ");
                    senha = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Acesso permitido!");
´´´

#### 2 - Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
´´´
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
´´´

#### 3 - Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.
´´´
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
´´´