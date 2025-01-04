using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountMangementSystem
{
    public interface InterestStrategy
    {
        double CalculateInterest(double balance);
    }

    // Standard Interest
    public class StandardInterest : InterestStrategy
    {
        //public void Interest(BankAccount bankAccount)
        //{
        //    Console.WriteLine($"Interest is 2% for the bank accound with id: {bankAccount.BankAccountId} ");
        //}
        public double CalculateInterest(double balance)
        {
            return balance * 0.03; // 
        }
    }

        // No Interest
        public class NoInterest : InterestStrategy
        {
            public double CalculateInterest(double balance)
        {
            return 0; // no interest
        }
        }
    
        

}
