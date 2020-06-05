using System;
using System.Collections.Generic;
using System.Text;

namespace Classes {
    class Programa {

        static void Main(string[] args) {

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: " + f);

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados atualizados: " + f);
        }
    }
}
