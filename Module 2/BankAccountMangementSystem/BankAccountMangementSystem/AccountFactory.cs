using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountMangementSystem
{
    public static class AccountFactory
    {
        public static BankAccount CreateAccount(string accountType, int bankAccountId, 
            int accountNumber, string accountHolderName, double balance)
        {
            

            if (accountType == "savings")
            {
                return new SavingAccount(bankAccountId, balance, accountNumber, accountHolderName);
            }
            else if (accountType == "checking")
            {
                return new CheckingAccount(bankAccountId, balance, accountNumber, accountHolderName);
            }
            else
            {
                throw new ArgumentException("Invalid account Type!");
            }
        }
    }
}
