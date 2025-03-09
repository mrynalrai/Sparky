namespace Sparky
{
    public interface ILogBook 
    {
        public int LogSeverityLevel { get; set; }
        public string LogType { get; set; }
        void Log(string message);
        bool LogToDb(string log);
        bool LogBalanceAfterWithdrawal(bool isSuccess, double balance);
        bool LogWithOutputResult(string str, out string outputStr);
        bool LogWithRefObj(ref Customer customer);
    }
    public class LogBook : ILogBook
    {
        public int LogSeverityLevel { get; set; }
        public required string LogType { get; set; }

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

        public bool LogWithOutputResult(string str, out string outputStr)
        {
            outputStr = "Hello " + str;
            return true;
        }

        public bool LogWithRefObj(ref Customer customer)
        {
            return true;
        }
    }
}