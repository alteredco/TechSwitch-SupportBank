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
            Printer sbPrinter = new Printer();
            string csvPath = @"support-bank-resources-master\Transactions2014.csv";
            Reader transactionReader = new Reader();
            var transactionList = transactionReader.List(csvPath);
            Bank sbBank = new Bank();
            var newAccounts = sbBank.createAccounts(transactionList);
            var updatedAccounts = sbBank.updateWallets(newAccounts, transactionList);
            string input =  sbPrinter.Menu();
            sbPrinter.PrintLists(input, transactionList, updatedAccounts);

            Console.ReadLine();
        }
    }
}