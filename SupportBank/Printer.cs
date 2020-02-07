using System;
using System.Collections.Generic;

namespace SupportBank
{
    public class Printer
    {
        private string Menu()
        {
            Console.WriteLine("Please choose what you would like to see a list of: ");
            Console.Write("Type 'ListAll' to see all transactions. Type List[AccountName] to see a specific account.: ");
            var input = Console.ReadLine();
            return input;
        }
    }
}