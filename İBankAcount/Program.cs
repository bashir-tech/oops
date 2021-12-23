using System;

namespace İBankAcount
{

    class Program
    {
        static void Main(string[] args)
        {

            var saver = new Acountsaver();
            saver.Deposit(500);
            saver.Withdraw(500);
            saver.Deposit(500);
         
            Console.WriteLine("current amount:"+ saver.Balance);
            Console.WriteLine(saver);

            Console.WriteLine(DateTime.Now.ToString("G"));
            Console.ReadKey();
        }
    }
}

