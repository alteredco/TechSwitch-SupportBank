using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SupportBank
{
    public class Printer
    {
        public string Menu()
        {
            try
            {
                Console.WriteLine("WELCOME TO SUPPORT BANK");
                Console.WriteLine("========================");
                Console.WriteLine("=======================");
                Console.Write("Please enter the number of your choice: 1) List All, 2) List Account  ");
                string input = Console.ReadLine();
                return input;
            }
            catch (FormatException e)
            {
                Console.WriteLine("There is something wrong with the number you entered. Try again! "+ e.Message);
                throw;
            }
            
        }

        public void PrintLists(string input,List<Payment> transactions, List<Wallet> accountList)
        {
            var listOfNames = new List<string>();
            foreach (var item in transactions)
            {
                if (!listOfNames.Contains(item.Receiver))
                {
                    listOfNames.Add(item.Receiver);
                }
            }

            var names = String.Join(", ", listOfNames.ToArray());
            
            
            if (input == "1")
            {
                foreach (var account in accountList)
                {
                    Console.WriteLine(
                        $"Name: {account.Owner}, Balance: £{account.Balance}");
                }
            }
            else if (input == $"2")
            {
                Console.WriteLine($"Which account would you like to see?: {names}");
                Console.Write("Please type in a name: ");
                var name = Console.ReadLine();
                foreach (var account in accountList)
                {
                    if (account.Owner == name)
                    {
                        Console.WriteLine($"{account.Owner}'s transactions: ");
                        Console.WriteLine("========================");
                        foreach (var activity in account.TransactionList)
                        {
                            Console.WriteLine($"Date: {activity.Date}, Sender: {activity.Sender}, Receiver: {activity.Receiver}, Activity: {activity.Activity}, Amount: £{activity.Amount} ");
                        }
                        if (account.Balance < 0)
                        {
                            Console.WriteLine("========================");
                            Console.WriteLine("{0} is down by this much: £{1} . You are owed a coffee {0}!", account.Owner,account.Balance);
                        }
                        else
                        {
                            Console.WriteLine("========================");
                            Console.WriteLine("{0} owes this much: £{1} . Pay up {0}!", account.Owner,account.Balance);
                        }
                        
                    }
                }
            }
        }
    }
}