using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace SupportBank
{
    public class Bank
    {
        public void sortTransactions(List<Payment> transactions)
        {
            foreach (var item in transactions)
            {
                Wallet account = new Wallet
                {
                    Balance = 0,
                    AmountOut = 0,
                    AmountIn = 0,
                    Owner = item.Receiver,
                    TransactionList = item,
                };
                
                // if (item.Receiver == Wallet.Owner)
                // {
                //     Wallet.Total += item.Amount;
                // }
                //
                // if (item.Sender == Wallet.Owner)
                // {
                //     Wallet.Balance -= item.Amount;
                // }
                //
                // return Wallet.Balance;
            }
            
        }

        public void groupUsers(List<Payment> transactions)
        {
            List<Payment> sortedByUser = transactions.OrderBy(o => o.Receiver).ToList();
            foreach (var item in sortedByUser)
            {
                Wallet account = new Wallet
                {
                    Balance = item.Amount,
                    AmountOut = 0,
                    AmountIn = item.Amount,
                    Owner = item.Receiver,
                };
                
                Console.WriteLine("{0} has £{1} in their wallet.", account.Owner, account.Balance);
            }
        }
    }
}