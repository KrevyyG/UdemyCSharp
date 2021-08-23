using System;

namespace ExercVetores
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
