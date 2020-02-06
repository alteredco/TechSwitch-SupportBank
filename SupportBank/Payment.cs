using System;

namespace SupportBank
{
    public partial class Payment
    {
        public DateTime Date { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Activity { get; set; }
        public double Amount { get; set; }
    }
}