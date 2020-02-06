using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SupportBank
{
    public class Transaction
    {
        private List<Payment> Transactions { get; set; }

        public List<Payment> PaymentCollection(Payment payment)
        {
            Transactions = new List<Payment>();
            Transactions.Add(payment);
           
            return Transactions;
        }
        
    }
    
    
}