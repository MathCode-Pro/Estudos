﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_e_Polimorfismo.Entities {
    class Employee {

        public string Name { get; private set; }
        public int Hours { get; private set; }
        public double ValuePerHour { get; private set; }

        public Employee() {
        }

        public Employee(string name, int hours, double valuePerHour) {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double payment() {

            return ValuePerHour * Hours;
        }

        public override string ToString() {

            return Name + " - $ " + payment().ToString("F2");
        }
    }
}
