using Classes_e_Métodos_Abstratos.Entities;
using System;
using System.Collections.Generic;

namespace Classes_e_Métodos_Abstratos {
    class Program {
        static void Main(string[] args) {

            List<Contribuintes> contribuintes = new List<Contribuintes>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                Console.WriteLine("Tax payer #{0} data:", i);
                Console.Write("Individual or company (i/c?) ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (ch.Equals('i')) {

                    Console.Write("Health expenditures: ");
                    double gastoSaude = double.Parse(Console.ReadLine());

                    contribuintes.Add(new Fisica(name, anualIncome, gastoSaude));

                } else {

                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    contribuintes.Add(new Juridica(name, anualIncome, employees));
                }
            }

            Console.WriteLine();

            Console.WriteLine("TAXES PAID:");

            double cont = 0.0;

            foreach (Contribuintes c in contribuintes) {

                Console.WriteLine(c);
                cont += c.ImpostoPago();
            }

            Console.WriteLine();

            Console.WriteLine("TOTAL TAXES: $ " + cont.ToString("F2"));
        }
    }
}
