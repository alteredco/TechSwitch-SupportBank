using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace SupportBank
{
    public class Bank
    {
        public List<Wallet> createAccounts(List<Payment> transactions)
        {
            List<Wallet> accountList = new List<Wallet>();
            List<Payment> sortedByUser = transactions.OrderBy(o => o.Receiver).ToList();
            var potOfMoney = transactions.Sum(i => i.Amount);
            Console.WriteLine($"Total Bank Balance: {potOfMoney}");
            
            // var groupedReceiverList = sortedByUser.GroupBy(n => n.Receiver).Select(grp => grp.ToList()).ToList();
            // foreach (var receiverGroup in groupedReceiverList)
            // {
            //     double moneyIn = 0;
            //     foreach (var receiver in receiverGroup)
            //     {
            //         moneyIn = receiverGroup.Sum(i => i.Amount);
            //         Console.WriteLine(" Name: {0} , MoneyIn: {1} ", receiver.Receiver, moneyIn);
            //     }
            // }
            // var groupedSenderList = sortedByUser.GroupBy(n => n.Sender).Select(grp => grp.ToList()).ToList();
            // foreach (var senderGroup in groupedSenderList)
            // {
            //     double moneyOut = 0;
            //     foreach (var sender in senderGroup)
            //     {
            //         moneyOut = senderGroup.Sum(i => i.Amount);
            //         Console.WriteLine(" Name: {0} , MoneyOut: {1} ", sender.Sender, moneyOut);
            //     }
            // }

            foreach (var item in sortedByUser)
            {
                Wallet account = new Wallet
                {
                    Balance = 0,
                    Owner = item.Receiver,
                    TransactionList = item,
                };
                // account.Balance = account.CalculateTotal(account.Balance, account.AmountIn, account.AmountOut);
                // account.GetBalance(account.Owner, account.Balance);
                accountList.Add(account);
            }

            return accountList;
        }
        
    }
}