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

            //Create list of unique users
            var listOfNames = new List<string>();
            foreach (var item in transactions)
            {
                if (!listOfNames.Contains(item.Receiver))
                {
                    listOfNames.Add(item.Receiver);
                }
            }
            
            //Create wallets with owners
            foreach (var name in listOfNames)
            {
                Wallet account = new Wallet
                {
                    Balance = 0,
                    Owner = name,
                    TransactionList = new List<Payment>()
                };
                accountList.Add(account);
            }
            
            //Create list of transactions for each account
            foreach (var transaction in transactions)
            {
                foreach (var account in accountList)
                {
                    if (account.Owner == transaction.Sender || account.Owner == transaction.Receiver)
                    {
                        account.TransactionList.Add(transaction);
                    }
                }
            }
            return accountList;
        }

        public List<Wallet> updateWallets(List<Wallet>accountList, List<Payment> transactions)
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
            }

            return accountList;
        }
    }
}