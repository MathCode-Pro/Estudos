using System;
using System.Collections.Generic;
using System.Text;

namespace Herança_e_Polimorfismo_2.Entities {
    class UsedProduct : Product {

        public DateTime ManufactureDate { get; private set; }

        public UsedProduct() {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() {

            return $"{Name} (used) $ {Price:F2} (Manufacture date: {ManufactureDate:dd/MM/yyyy})";
        }
    }
}
