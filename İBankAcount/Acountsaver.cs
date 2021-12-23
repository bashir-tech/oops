using System;
using System.Collections.Generic;
using System.Text;

namespace İBankAcount
{
    public class Acountsaver : İBankAcount
    {
        private decimal _Balance;
        public decimal Balance => _Balance;

        public void Deposit(decimal Amount)
        {
            _Balance += Amount;
        }

        public bool Withdraw(decimal Amount)
        {
            if (_Balance>=Amount)
            {
                _Balance  -= Amount;
                return true;
            }
         
            
                Console.WriteLine("error");
                return false;
            
        }

        public override string ToString()=>$"bank server :Balanace  {_Balance} ";
        
    }
}
