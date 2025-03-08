namespace Sparky
{
    public interface ILogBook 
    {
        void Log(string message);
    }
    public class LogBook : ILogBook
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}