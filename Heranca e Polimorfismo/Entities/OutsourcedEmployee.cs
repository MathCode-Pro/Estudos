using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_e_Polimorfismo.Entities {
    class OutsourcedEmployee : Employee {

        public double AdditionalCharge { get; private set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour) {

            AdditionalCharge = additionalCharge;
        }

        public override double payment() {

            return base.payment() + AdditionalCharge * 1.1;
        }
    }
}
