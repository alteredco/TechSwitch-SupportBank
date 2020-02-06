using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SupportBank
{
    public class Transaction
    {
        private ArrayList Payments { get; set; }

        public ArrayList PaymentCollection(object payment)
        {
            Payments = new ArrayList();
            Payments.Add(payment);
            foreach (var item in Payments)
            {
                Console.WriteLine(Payments.Count);
            }
            return Payments;
        }
        
    }
    
    
}