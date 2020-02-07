using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace SupportBank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string csvPath = @"support-bank-resources-master\Transactions2014.csv";
            
            Reader transactionReader = new Reader();
            transactionReader.List(csvPath);

            Console.ReadLine();
        }
        
    }
}