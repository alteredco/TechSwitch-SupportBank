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
                Console.WriteLine(item.Receiver);
            }
        }
    }
}