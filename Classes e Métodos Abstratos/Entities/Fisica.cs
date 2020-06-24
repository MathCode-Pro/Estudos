using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_e_Métodos_Abstratos.Entities {
    internal class Fisica : Contribuintes {

        internal double GastoSaude { get; private set; }
        internal Fisica(string name, double anualIncome, double gastoSaude) : base(name, anualIncome) {

            GastoSaude = gastoSaude;
        }

        internal override double ImpostoPago() {

            if (AnualIncome < 20000.00) {

                if (GastoSaude != 0.0) {

                    return (AnualIncome * 15) / 100 - (GastoSaude * 50) / 100;
                }

                return (AnualIncome * 15) / 100;

            } else {

                if (GastoSaude != 0.0) {

                    return (AnualIncome * 25) / 100 - (GastoSaude * 50) / 100;
                }

                return (AnualIncome * 25) / 100;
            }
        }
    }
}
