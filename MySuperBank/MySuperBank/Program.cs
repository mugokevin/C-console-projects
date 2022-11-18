using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car".Pluralize());
            Console.WriteLine("Pant".Pluralize());
            Console.WriteLine("Octopus".Pluralize());


            var account = new BankAccount("Kevin", 100000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(11549, DateTime.Now, "Car");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(5000, DateTime.Now, "playstation");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(4000, DateTime.Now, "shopping");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());


            Console.ReadLine();
        }
    }
}
