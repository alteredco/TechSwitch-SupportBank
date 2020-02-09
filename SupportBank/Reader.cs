using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SupportBank
{
    public class Reader
    {
        private string FilePath { get; set; }

        public List<Payment> List(string FilePath)
        {
            try
            {
                var lines = File.ReadAllLines(FilePath).Skip(1);
                List<Payment> transactionsList = new List<Payment>();
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
                    transactionsList.Add(sbPayment);
                }

                return transactionsList;
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong! Have you checked your filepath? " + e.Message);
                throw;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Something is wrong with the format of your file! " + e.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong! "+ e.Message);
                throw;
            }
        }
    }
}