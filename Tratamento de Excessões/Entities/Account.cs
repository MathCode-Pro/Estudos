using System;
using System.Collections.Generic;
using System.Text;
using Tratamento_de_Excessões.Entities.Exceptions;

namespace Tratamento_de_Excessões.Entities {
    internal class Account {

        internal int Number { get; private set; }
        internal string Holder { get; private set; }
        internal double Balance { get; private set; }
        internal double WithdrawLimit { get; private set; }

        public Account() {
        }

        internal Account(int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        internal void Deposit(double amount) {
            Balance += amount;
        }

        internal void Withdraw(double amount) {

            if (amount > WithdrawLimit)
                throw new DomainException("The amount exceeds withdraw limit - Withdraw limit: " + WithdrawLimit.ToString("F2"));

            else if (amount > Balance)
                throw new DomainException("Not enough balance.");

            Balance -= amount;
        }

        public override string ToString() {
            return Balance.ToString("F2");
        }
    }
}
