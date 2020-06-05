using System;
using System.Collections.Generic;
using System.Text;

namespace Staticos {
    class Conta {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double deposito) : this(numero, titular) {

            Deposito(deposito);
        }
        public void Deposito(double valor) {

            Saldo += valor;
        }

        public void Saque(double valorSaque) {

            Saldo -= valorSaque + 5;
        }

        public override string ToString() {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo:F2}";
        }
    }
}
