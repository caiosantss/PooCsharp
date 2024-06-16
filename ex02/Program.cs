using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ex02
{
    // Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionario1, funcionario2;
            funcionario1 = new Funcionarios();
            funcionario2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            funcionario1.NOME = Console.ReadLine();
            Console.Write("Salario: ");
            funcionario1.SALARIO = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            funcionario2.NOME = Console.ReadLine();
            Console.Write("Salario: ");
            funcionario2.SALARIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media, soma; 
            soma = funcionario2.SALARIO + funcionario1.SALARIO;
            media = soma / 2.0;

            Console.WriteLine($"O salario medio desses funcionarios é: {media.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
        }
    }

    class Funcionarios
    {
        public string NOME;
        public double SALARIO;
    }
}
