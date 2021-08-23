# Exercícios efetuados durante o aprendizado em Linguagem C#
Exercícios de Fixação sobre os seguintes tópicos:
- Vetores

# Dependencias
#### .NET Core Framework 3.0
#### Biblioteca "using System;"
#### Biblioteca "using System.Globalization;"
#### Biblioteca "using System.Collections.Generic;"

### Execícios
#### 1 - A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos identificados pelos números 0 a 9.
#### Quando um estudante deseja alugar um quarto, deve-se registrar o nome e email deste estudante.
#### Fazer um programa que inicie com todos os dez quartos vazios, e depois leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos N estudantes. Para cada registro de aluguel, informar o nome e email do estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto, conforme exemplo.

##### Arquivo Program.cs
´´´
            Console.Write("Quantos quartos serão alugados ?: ");
            int qtdeQuart = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Estudante[] vect = new Estudante[10];

            for (int i = 1; i <= qtdeQuart; i++)
            {
                Console.WriteLine("Alugel #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
                Console.WriteLine("");
            }

            Console.WriteLine("Quartos alugados ");
            Console.WriteLine("");

            for (int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
´´´

##### Arquivo Estudante.cs (Classe)
´´´
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + Email;
        }
´´´