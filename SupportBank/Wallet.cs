using System;

namespace SupportBank
{
    public class Wallet
    {
        public double Total { get; set; }
        public double AmountOut { get; set; }
        public double AmountIn { get; set; }
        
        public void GetBalance(string name, double total)
        {
            Console.WriteLine($"{name} has a balance of: {total}");
        }

        public double CalculateTotal(double total, double moneyIn, double moneyOut)
        {
            total += moneyIn;
            total -= moneyOut;
            return total;
        }
    }
    
    
    
}