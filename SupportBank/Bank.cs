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
            
            //Create pot of money
            var potOfMoney = transactions.Sum(i => i.Amount);
            
            //Create list of unique users
            var listOfNames = new List<string>();
            foreach (var item in transactions)
            {
                if (!listOfNames.Contains(item.Receiver))
                {
                    listOfNames.Add(item.Receiver);
                }
            }
            
            //Create wallet
            foreach (var item in listOfNames)
            {
                Wallet account = new Wallet
                {
                    Balance = 0,
                    Owner = item,
                };
                accountList.Add(account);
            }
            return accountList;
        }

        public void updateWallets(List<Wallet>accountList, List<Payment> transactions)
        {
            foreach (var account in accountList)
            {
                foreach (var transaction in transactions)
                {
                    if (account.Owner == transaction.Sender)
                    {
                        account.Balance = account.Balance - transaction.Amount;
                    }

                    if (account.Owner == transaction.Receiver)
                    {
                        account.Balance = account.Balance + transaction.Amount;
                    }
                }
                Console.WriteLine(account.Balance);
            }
        }
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
    }
}