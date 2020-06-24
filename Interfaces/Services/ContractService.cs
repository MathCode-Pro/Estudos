using Interfaces.Entities;
using Interfaces.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Services {
    class ContractService {

        IPaymentService _calculationInstallments;
        private Contract Contract;
        private int Mounths;

        public ContractService(IPaymentService CalculationInstallments, int mounths) {

            _calculationInstallments = CalculationInstallments;
            Mounths = mounths;
        }

        public void ProcessContract(Contract contract) {

            for (int i = 1; i <= Mounths; i++) {

                DateTime date = contract.Date.AddMonths(i);

                double amount = _calculationInstallments.CalcValue(i, (contract.TotalValue / Mounths));

                contract._installment.Add(new Installment { DueDate = date, Amount = amount });
            }
        }
    }
}
