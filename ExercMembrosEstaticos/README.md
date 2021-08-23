# Exercícios efetuados durante o aprendizado em Linguagem C#
Exercícios de Fixação sobre os seguintes tópicos:
- Classes
- Atributos
- Métodos
- Membros estáticos

# Dependencias
#### .NET Core Framework 3.0
#### Biblioteca "using System;"
#### Biblioteca "using System.Globalization;"
#### Biblioteca "using System.Collections.Generic;"

### Execícios
#### 1 - Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.

##### Arquivo Program.cs
```
            Console.Write("Qual é a cotação do dólar? ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtdeDol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.vlrDolar(cot, qtdeDol);

            Console.WriteLine("Valor a ser pago em Reais: " + result.ToString("F2", CultureInfo.InvariantCulture)) ;
```

##### Arquivo ConversorDeMoeda.cs (Classe)
```
        public static double Iof = 6.0;

        public static double vlrDolar(double cot, double qtdeDol)
        {
            double total = cot * qtdeDol;
            return total + total * Iof / 100;
        }
```