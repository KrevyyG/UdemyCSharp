using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercLists
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
