namespace Sparky
{
    public class BankAccount
    {
        private readonly ILogBook _logBook;

        public double Balance { get; set; }
        public BankAccount(ILogBook logBook)
        {
            Balance = 0;
            _logBook = logBook;
        }

        public bool Deposit(double amount)
        {
            Balance += amount;
            _logBook.Log($"Deposited amount: {amount}");
            return true;
        }

        public bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                _logBook.Log($"Withdrew amount: {amount}");
                return true;                
            }
                
            return false;
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}