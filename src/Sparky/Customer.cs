namespace Sparky
{
    public class Customer
    {
        public string? Greeting { get; set; }
        public bool IsPlatinum { get; set; }

        public Customer()
        {
            IsPlatinum = false;
        }
        public string GreetCustomer(string firstName, string lastName)
        {
            Greeting = $"Bonjour {firstName} {lastName}";
            return Greeting;
        }
    }
}