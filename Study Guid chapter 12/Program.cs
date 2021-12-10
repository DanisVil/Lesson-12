using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using BankDll;

namespace Study_Guid_chapter_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //t12.1
            EUBankAccount a = new EUBankAccount(0, BankAccount.Type.Current);
            BankAccount b = a;
            Console.WriteLine(a==b);
            Console.WriteLine(a.ToString());
            Console.WriteLine();
            //t12.2
            RationalNumber first = new RationalNumber(7, 4);
            RationalNumber second = new RationalNumber(9, 11);
            Console.WriteLine((int)first);
            Console.WriteLine();
            //ht12.1
            ComplexNumber f = new ComplexNumber(1, -5);
            ComplexNumber s = new ComplexNumber(-2, 3);
            Console.WriteLine(f * s);
            //ht12.2
            Book stateAndReloveution = new Book("В.И.Ленин", "Государство и революция", "Жизнь и знание"),
                Capital = new Book("К.Маркс", "Капитал", ""),
                AtTheTopOfMyVoice = new Book("В.Маяковский", "Во весь голос", ""),
                ImperialismTheHighestStageOfCapitalism = new Book("В.И.Ленин", "Империализм, как высшая стадия капитализма",
                "Жизнь и знание"),
                CommunistManifesto = new Book("К.Маркс", "Манифест коммунистической партии", "");
            Bookshelf bookshelf = new Bookshelf(stateAndReloveution, Capital, AtTheTopOfMyVoice, 
                ImperialismTheHighestStageOfCapitalism, CommunistManifesto);
            Console.WriteLine(bookshelf);
            bookshelf.SetSortingMethod("по издательству");
            bookshelf.Sort();
            Console.WriteLine(bookshelf);

            Console.ReadKey();
        }
    }
}
