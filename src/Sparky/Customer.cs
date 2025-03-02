namespace Sparky
{
    public class Customer
    {
        public string? Greeting { get; set; }
        public string GreetCustomer(string firstName, string lastName)
        {
            Greeting = $"Bonjour {firstName} {lastName}";
            return Greeting;
        }
    }
}