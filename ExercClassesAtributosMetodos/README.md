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
#### 1 - Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe como mostrado no projeto ao lado.

##### Arquivo Program.cs
```
                Retangulo ret;
                ret = new Retangulo();

                Console.Write("Entre com a largura de um retângulo: ");
                ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Entre com a altura de um retângulo: ");
                ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Console.WriteLine("Área: " + ret.Area());
                Console.WriteLine("Prímetro: " + ret.Perimetro());
                Console.WriteLine("Diagonal: " + ret.Diagonal());
```

##### Arquivo Retangulo.cs (Classe)
```
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }
        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
```

#### 2 - Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário. Use a classe projetada abaixo.

##### Arquivo Program.cs
```
                Funcionario func;
                func = new Funcionario();

                Console.Write("Nome: ");
                func.Nome = Console.ReadLine();
                Console.Write("Salário Bruto: ");
                func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Imposto: ");
                func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                Console.WriteLine("Funcionário: " + func);
                Console.WriteLine();

                Console.Write("Digite a porcentagem para aumentar o salário: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentarSalario(porcentagem);
                Console.WriteLine();

                Console.WriteLine("Dados atualizados: " + func);
```

##### Arquivo Funcionario.cs (Classe)
```
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto =  SalarioBruto + (SalarioBruto * porcentagem / 100);
        }

        public override string ToString()
        {
            return Nome 
                + ", " 
                + "$ " 
                + SalarioLiquido().ToString("F2");
        }
```

#### 3 - Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este problema.

##### Arquivo Program.cs
```
                Aluno aluno;
                aluno = new Aluno();

                Console.Write("Nome do aluno: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite as 3 notas do aluno: ");
                aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine(aluno.NotaFinal());

                if (aluno.Aprovado())
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                    Console.WriteLine("Faltaram " 
                        + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) 
                        + " pontos");
                }
```

##### Arquivo Retangulo.cs (Classe)
```
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal() 
        {
            return N1 + N2 + N3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado() == true)
            {
                return 0.0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }
```