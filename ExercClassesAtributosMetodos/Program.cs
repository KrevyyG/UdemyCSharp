using System;
using System.Globalization;

namespace ExercClassesAtributosMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite qual o número do exercício a ser testado de 1 a 3: ");
            int nrExerc = int.Parse(Console.ReadLine());
            Console.Clear();

            if (nrExerc == 1)
            {
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

            }

            else if (nrExerc == 2)
            {
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

            }

            else
            {
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
            }
        }
    }
}
