using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDll;
using BuildingDll;

namespace Study_Guid_chapter_13
{
    class Program
    {
        static void Main(string[] args)
        {
            RUBBankAccount firstAccount = new RUBBankAccount(500, BankAccount.Type.Current);
            USDBankAccount secondAccount = new USDBankAccount(40, BankAccount.Type.Saving);
            firstAccount.TransferMoney(secondAccount, 300);
            Console.WriteLine(firstAccount);
            Console.WriteLine(secondAccount);
            firstAccount.Dispose();
            secondAccount.Dispose();

            Console.ReadKey();
        }
    }
}
