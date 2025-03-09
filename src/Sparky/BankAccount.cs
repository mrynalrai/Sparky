namespace Sparky
{
    public class BankAccount
    {
        private readonly ILogBook _logBook;

        private double Balance { get; set; }
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
            bool isSuccess = false;
            if (Balance >= amount)
            {
                _logBook.LogToDb($"Withdrew amount: {amount}");
                Balance -= amount;
                isSuccess = true;             
            }
            _logBook.LogBalanceAfterWithdrawal(isSuccess, Balance);
            return isSuccess;
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}