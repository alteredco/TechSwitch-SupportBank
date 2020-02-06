using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SupportBank
{
    public class Reader
    {
        private string FilePath { get; set; }

        public void ReadFile(string FilePath)
        {
            try {
                var lines = File.ReadAllLines(FilePath).Skip(1);
                foreach (string line in lines)
                {
                    string[] splitLine = line.Split(',');
                    DateTime dateString = DateTime.Parse(splitLine[0]);
                    string fromNameString = splitLine[1];
                    string toNameString = splitLine[2];
                    string narrativeString = splitLine[3];
                    double amountString = double.Parse(splitLine[4]);

                    Payment sbPayment = new Payment
                    {
                        Date = dateString,
                        Sender = fromNameString,
                        Receiver = toNameString,
                        Activity = narrativeString,
                        Amount = amountString,
                    };
                    Transaction sbTransaction = new Transaction();
                    Bank sbBank = new Bank();
                    sbBank.sortTransactions(sbTransaction.PaymentCollection(sbPayment));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong! "+ e.Message);
                throw;
            }
        }
    }
}