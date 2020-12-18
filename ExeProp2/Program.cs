using System;
using System.Globalization;
using System.Collections.Generic;
using ExeProp2.Entities;

namespace ExeProp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();

            Console.Write("Enter the number of tax payers:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Indivídual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(name, income, expenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int number = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(name, income, number));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double totalTax = 0.0;
            foreach (Pessoa pessoa in lista)
            {
                double tax = pessoa.Imposto(pessoa.RendaAnual);
                Console.WriteLine(pessoa.Nome + " " + tax.ToString("F2", CultureInfo.InvariantCulture));
                totalTax += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
