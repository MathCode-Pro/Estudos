using Interfaces.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Services {
    class PaypalServices : IPaymentService {

        public double CalcValue(int mounth, double value) {

            double simple = value + (value * 0.01 * mounth);
            double fee = simple * 0.02;
            return simple + fee;
        }
    }
}
