# Exercícios efetuados durante o aprendizado em Linguagem C#
Exercícios de Fixação sobre os seguintes tópicos:
- Contrutores
- Plavra this
- Sobrecarga
- Encapsulamento

# Dependencias
#### .NET Core Framework 3.0
#### Biblioteca "using System;"
#### Biblioteca "using System.Globalization;"
#### Biblioteca "using System.Collections.Generic;"

### Execícios
#### 1 - Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
#### Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o saque e/ou pagar a taxa.
#### Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre mostrando os dados da conta após cada operação.

##### Arquivo Program.cs
´´´
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do títular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial ? (s/n): ");
            char depIniSouN = Char.Parse(Console.ReadLine());

            ContaBancaria cb = new ContaBancaria(numero, titular);

            if (depIniSouN == 's')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb = new ContaBancaria(numero, titular, saldo);
            }

            Console.WriteLine("");

            Console.WriteLine(cb);

            Console.WriteLine("");

            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cb);

            Console.WriteLine("");

            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cb);

´´´

##### Arquivo Funcionario.cs (classe)
´´´
        public int Numero { get; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this (numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = (Saldo - quantia) - 5;
        }

        public override string ToString()
        {
            return "Conta " 
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
´´´