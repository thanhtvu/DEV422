using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountMangementSystem
{
    public class CheckingAccount : BankAccount
    {
        // field
        public double InterestRate { get; set; }

        // constructor
        public CheckingAccount(int bankAccountId, double balance, int accountNumber, string accountHolderName)
            : base(bankAccountId, balance, accountNumber, accountHolderName)
        {
            InterestRate = 0;
        }

        // overwriting from parent class (BankAccount.cs)
        public override void CalculateInterest()
        {
            Console.WriteLine($"Interest for this bank account will be {InterestRate} ");
        }

    }
}
