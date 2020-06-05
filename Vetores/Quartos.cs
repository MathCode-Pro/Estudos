using System;
using System.Collections.Generic;
using System.Text;

namespace Vetores {
    struct Quartos {

        public string Nome;
        public string Email;
        public int Quarto;

        public override string ToString() {
            return Quarto + ": " + Nome + ", " + Email;
        }
    }
}
