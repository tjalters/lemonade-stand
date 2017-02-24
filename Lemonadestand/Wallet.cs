using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Wallet
    {
        public decimal balance;


        public Wallet()
        {
            balance = 20.00m;
        }
        public decimal SubtractFromBalance(decimal amountToSubtract)
        {
            if (balance - amountToSubtract >= 0)
            {
               return balance -= amountToSubtract;

                
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
            
        }

        public void AddToBalance(decimal amount)
        {
            balance += amount;
        }
    }
}
