using System;
using System.Collections.Generic;
using System.Text;

namespace Staticos {
    class Cliente {

        static void Main(String[] args) {

            Conta conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositar = char.Parse(Console.ReadLine());

            if (depositar.Equals('s') || depositar.Equals('S')) {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                conta = new Conta(numero, titular, saldo);

            } else
                conta = new Conta(numero, titular);


            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }

    }
}
