using System;
using System.Collections.Generic;
using System.Text;

namespace Herança_e_Polimorfismo_2.Entities {
    class Product {

        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product() {
        }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag() {

            return $"{Name} $ {Price:F2}";
        }
    }
}
