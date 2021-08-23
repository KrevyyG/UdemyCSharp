# Exercícios efetuados durante o aprendizado em Linguagem C#
Exercícios de Fixação sobre os seguintes tópicos:
- Classes
- Atributos
- Métodos
- Membros Estáticos
- Contrutores
- Palavra this
- Sobrecarga 
- Encapsulamento
- Arrays
- Listas

# Dependencias
#### .NET Core Framework 3.0
#### Biblioteca "using System;"
#### Biblioteca "using System.Globalization;"
#### Biblioteca "using System.Collections.Generic;"

# Observações
#### Comandos
- Comando "Console.WriteLine()" sempre adiciona um carácter de quebra de linha após escrever algo no output.
- Comando "Console.Write()" escreve um ou mais valores no output.
- Comando "Int + nome_variavel =" serve para atribuir valores a essa variável declarada.
- Comando "Console.ReadLine()" Retorna o valor da linha inteira.
- Comando "int.Parse()" serve para converter o conteúdo capturado pelo "Console.ReadLine" para uma variável do tipo int. (O mesmo funciona para outros tipos de variáveis).
- Comando "CultureInfo.InvariantCulture" serve para o sistema conseguir entender um número decimal usando tanto "." quanto ",".
- Comando "nome_variavel.ToString("F2")" serve para delimitar a quantidade de casas decimais por meio do "F2".
- Comando "if", "else if", "else" servem para realizar a condição de cada função a ser efetuada.
- Comando "Math.Sqrt" serve para calcular a raiz quadrada.
- Comando "Console.Clear()" serva para limpar o CMD.
- Comando "Console.ReadLine().Split(' ')" serve para recortar o conteúdo digitado separado por espaços.
- Comando "string[] nome_vetor = new string[10]" serve para delcarar um vetor com 10 espaços.
- Comando "string nome_variavel = nome_vetor[2]" serve para atribuir o valor de um vetor na posição requerida a uma variável.
- Comando "for (int i = 0; i <= n; i++)" serve para criar um laço repetitivo até certa condição.
- Comando "while (nome_variavel != 2002)" serve para repetir determinada ação enquanto a condição for verdadeira.
- Comando "Nome_Classe nome_variavel = new Nome_Classe()" este comando serve para declarar uma variável do tipo da classe em questão, assim fazendo com que a variável utilize os atributos dessa classe.
- Comando "nome_variavel.Nome_Método()" é o comando que utiliza o método contruído na classe.
- Comandos "{ get; }", "{ get; set; }" e "{ get; private set; }" servem para encapsular as variáveis, deixando com que sejam alteradas de acordo com a privacidade exigida.
- Comando "ContaBancaria(int numero, string titular)" é um construtor contendo 2 argumentos, assim podendo iniciar cada um desses argumentos com determinado valor.
- Comando ": this (atributo1, atributo2)" serve para fazer com que o contrutor seguinte utilize os valores declarados no contrutor anterior.
- Comando "public override string ToString()" faz com que seja editável o conteúdo que será mostrado ao imprimir a variável do tipo da Classe.
- Comando "List<string> nome_variavel = new List<string>()" serve para declarar uma nova lista.
- Comando "list.Add(new string(id, nome, salario))" serve para adicionar os valores das varáveis na lista.
- Comando "list.Find(x => x.Id == findId)" serve para procurar o conteúdo de acordo com a condição.
- Comando "public Nome_Classe(int variavel1, string variavel1, double variavel1)" serve para declarar um novo contrutor, ja que há 3 variaveis como argumentos significa que todas as vezes que utilizar ele, deverá ser informado os 3 argumentos.
- Comando "int[,] mat = new int[m,n]" serve para declarar uma array com m linhas e n colunas.