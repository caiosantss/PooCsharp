using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    internal class Program
    {

        // Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha

        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.NOME = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.IDADE =int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.NOME = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.IDADE = int.Parse(Console.ReadLine());

            if (pessoa1.IDADE > pessoa2.IDADE)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.NOME}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.NOME}");
            }

            Console.ReadLine();
        }
    }

    class Pessoa
    {
        public string NOME;
        public int IDADE;
    }
}
