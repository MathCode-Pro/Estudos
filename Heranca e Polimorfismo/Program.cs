using Heranca_e_Polimorfismo.Entities;
using System;
using System.Collections.Generic;

namespace Heranca_e_Polimorfismo {
    class Program {
        static void Main(string[] args) {

            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"Employee #{i} data:");

                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());


                if (outsourced == 'y') {

                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                } else
                    employees.Add(new Employee(name, hours, valuePerHour));
            }

            Console.WriteLine();

            Console.WriteLine("PAYMENTS:");

            foreach (Employee e in employees)
                Console.WriteLine(e);
        }
    }
}
