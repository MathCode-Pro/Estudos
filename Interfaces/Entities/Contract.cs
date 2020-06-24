using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities {
    class Contract {

        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; private set; }

        public List<Installment> _installment = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }
    }
}
