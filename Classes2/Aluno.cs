using System;
using System.Collections.Generic;
using System.Text;

namespace Classes2 {
    class Aluno {

        public string Nome;
        public double N1, N2, N3;

        public double NotaFinal() {

            return N1 + N2 + N3;
        }

        public bool Aprovacao() {

            if (NotaFinal() >= 60.00)
                return true;
            else
                return false;
        }

        public double Falta() {

            return 60.00 - NotaFinal();
        }
    }
}
