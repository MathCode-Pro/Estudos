using LINQ_LAMBDA.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace LINQ_LAMBDA {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> emp = new List<Employee>();

            using (StreamReader sr = File.OpenText(path)) {

                while (!sr.EndOfStream) {

                    string[] employee = sr.ReadLine().Split(',');
                    string name = employee[0];
                    string email = employee[1];
                    double salary = double.Parse(employee[2], CultureInfo.InvariantCulture);

                    emp.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double salaryFilter = double.Parse(Console.ReadLine());

            Console.WriteLine("Email of people whose salary is more than {0}:", salaryFilter.ToString("F2", CultureInfo.InvariantCulture));

            IEnumerable<string> emails = emp.Where(e => e.Salary > salaryFilter).OrderBy(e => e.Email).Select(e => e.Email);

            foreach (string empl in emails) {
                Console.WriteLine(empl);
            }

            double sum = emp.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
