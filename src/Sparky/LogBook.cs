namespace Sparky
{
    public interface ILogBook 
    {
        void Log(string message);
        bool LogToDb(string log);
        bool LogBalanceAfterWithdrawal(bool isSuccess, double balance);
    }
    public class LogBook : ILogBook
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public bool LogBalanceAfterWithdrawal(bool isSuccess, double balance)
        {
            if (isSuccess)
            {
                Console.WriteLine($"Success. Balance after withdrawal: {balance}");
                return true;
            }
            Console.WriteLine($"Transaction failed.");
            return false;
        }

        public bool LogToDb(string log)
        {
            Console.WriteLine(log);
            return true;
        }
    }
}