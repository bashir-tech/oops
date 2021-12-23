namespace İBankAcount
{
    public interface İBankAcount
    {
       decimal Balance { get; }

        void Deposit(decimal Amount);


        bool Withdraw(decimal Amount);
        

        

    }
}
