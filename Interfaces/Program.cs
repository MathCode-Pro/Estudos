using Interfaces.Entities;
using Interfaces.Services;
using System;
using System.Globalization;

namespace Interfaces {
    class Program {
        static void Main(string[] args) {

            Contract contract;
            ContractService contractService;

            Console.WriteLine("Enter contract data");
            Console.Write("Number:");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments: ");
            int mounth = int.Parse(Console.ReadLine());

            contract = new Contract(number,date,value);
            contractService = new ContractService(new PaypalServices(),mounth);

            contractService.ProcessContract(contract);

            Console.WriteLine("\nInstallments:");

            foreach(Installment i in contract._installment) {

                Console.WriteLine(i);
            }
        }
    }
}
