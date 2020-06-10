using System;
using System.Collections.Generic;
using System.Text;

namespace Herança_e_Polimorfismo_2.Entities {
    class ImportedProduct : Product {

        public double CustomsFree { get; private set; }

        public ImportedProduct() {
        }

        public ImportedProduct(string name, double price, double customsFree) : base(name, price) {
            CustomsFree = customsFree;
        }

        public override string PriceTag() {

            return $"{Name} $ {TotalPrice():F2} (Customs fee: $ {CustomsFree:F2})";
        }

        public double TotalPrice() {

            return Price + CustomsFree;
        }
    }
}
