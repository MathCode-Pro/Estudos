using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_e_Métodos_Abstratos.Entities {
    internal class Juridica : Contribuintes {

        public int NumeroFuncionarios { get; private set; }
        internal Juridica(string name, double anualIncome, int numeroFuncionarios) : base(name, anualIncome) {

            NumeroFuncionarios = numeroFuncionarios;
        }

        internal override double ImpostoPago() {

            if (NumeroFuncionarios <= 10)
                return (AnualIncome * 16) / 100;

            return (AnualIncome * 14) / 100;
        }
    }
}
