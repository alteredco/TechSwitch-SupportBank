using System;
using System.Collections.Generic;

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
                    Total = 0,
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
    }
}