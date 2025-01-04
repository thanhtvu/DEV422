using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountMangementSystem
{
    public class SavingAccount : BankAccount
    {
        

        // field
        public double InterestRate {  get; set; }


        // constructor
        public SavingAccount(int bankAccountId, double balance, int accountNumber, string accountHolderName) 
            :base (bankAccountId, balance, accountNumber, accountHolderName)
        {
            InterestRate = InterestRate;
        }


        // overwriting from parent class (BankAccount.cs)
        public override void CalculateInterest()
        {
            Console.WriteLine ($"Interest for this bank account will be {InterestRate} ");
        }
    }
}
