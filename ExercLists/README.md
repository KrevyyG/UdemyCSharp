# Exercícios efetuados durante o aprendizado em Linguagem C#
Exercícios de Fixação sobre os seguintes tópicos:
- Listas

# Dependencias
#### .NET Core Framework 3.0
#### Biblioteca "using System;"
#### Biblioteca "using System.Globalization;"
#### Biblioteca "using System.Collections.Generic;"

### Execícios
#### 1 - Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N funcionários. Não deve haver repetição de id.
#### Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário. Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos.
#### Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de aumento por porcentagem dada.

##### Arquivo Program.cs
´´´
            Console.Write("Quantos funcionários serão regitrados? : ");
            int qtdeFunc = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= qtdeFunc; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Digite o Id do funcionário que tera o salario incrementado: ");
            int findId = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == findId);
            if (func != null)
            {
                Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.IncrementarSalario(porcentagem);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Não existe funcionário com esse Id!");
                Console.WriteLine();
            }

            Console.WriteLine("Lista de funcionários atualizada: ");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
´´´

##### Arquivo Funcionario.cs (classe)
´´´
        public int Id { get; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncrementarSalario(double porcentagem)
        {
            Salario += (Salario / 100) * porcentagem;

        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture); 
        }
´´´