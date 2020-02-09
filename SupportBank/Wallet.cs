using System;
using System.Collections.Generic;

namespace SupportBank
{
    public class Wallet
    {
        public double Balance { get; set; }
        public string Owner { get; set; }
        public List<Payment> TransactionList { get; set; }
    }
    
    
    
}