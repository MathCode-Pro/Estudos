using System;
using System.Collections.Generic;

namespace Listas {
    internal class Program {
        static void Main(string[] args) {

            Employee employee = new Employee();

            List<Employee> listEmployee = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int employees = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= employees; i++) {

                Console.WriteLine("Employee #" + i + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                listEmployee.Add(new Employee(id, name, salary));

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int idSearch = int.Parse(Console.ReadLine());

            Employee increase = listEmployee.Find(x => x.Id == idSearch);

            if (increase == null) {

                Console.WriteLine("This id does not exist!");
                Console.WriteLine();

            } else {
                Console.WriteLine();
                Console.Write("Enter the percentage: ");
                double increasePercent = double.Parse(Console.ReadLine());

                increase.IncreaseSalary(increasePercent);

                Console.WriteLine();
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employee e in listEmployee) {
                Console.WriteLine(e);
            }
        }
    }
}
