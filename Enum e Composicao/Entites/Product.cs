using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_e_Composicao.Entites {
    class Product {
        public Product() {
        }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }
}
