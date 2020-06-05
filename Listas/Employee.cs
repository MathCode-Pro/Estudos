using System;
using System.Collections.Generic;
using System.Text;

namespace Listas {
    internal class Employee {

        internal int Id { get; private set; }
        internal string Name { get; private set; }
        internal double Salary { get; private set; }

        public Employee() {
        }

        internal Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public Employee(int id) {
            Id = id;
        }

        internal void IncreaseSalary(double percent) {

            double valuePercent = Salary * percent / 100;
            Salary += valuePercent;
        }

        public override string ToString() {
            return $"{Id}, {Name}, {Salary:F2}";
        }
    }
}
