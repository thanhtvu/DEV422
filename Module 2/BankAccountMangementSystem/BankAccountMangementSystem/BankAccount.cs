using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Base-class or Super-class
namespace BankAccountMangementSystem
{

    public abstract class BankAccount
    {
        public int BankAccountId { get; set; }
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }

        protected InterestStrategy _InterestStrategy;


        // Constructor
        public BankAccount (int bankAccountId, double balance, int accountNumber, string accountHolderName )
        {
            this.BankAccountId = bankAccountId;
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            this.Balance = balance;
        }


        // 1st Method
        public void setInterestStrategy (InterestStrategy interestStrategy)
        {
            this._InterestStrategy = interestStrategy;
        }

        public void Deposit(double x)
        {
            this.Balance = Balance + x;
        }

        public void Withdraw(double x)
        {
            if (this.Balance - x < 0)
            {
                Console.WriteLine("I'm sorry your check has bounced");
            }
            else
                this.Balance = Balance - x;
        }

        //
        public abstract void CalculateInterest();
    }
}
