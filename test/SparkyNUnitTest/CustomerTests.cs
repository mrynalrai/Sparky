using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CustomerTests
    {
        public required Customer customer;
        [SetUp]
        public void Init()
        {
            // Arrange
            customer = new Customer();
        }
        
        [Test]
        [TestCase("Jon", "Snow")]
        [TestCase("Sansa", "Stark")]
        public void GreetCustomer_InputNames_ReturnCorrectGreeting(string firstName, string lastName)
        {
            // Act
            customer.GreetCustomer(firstName, lastName);
            // Assert
            Assert.That(customer.Greeting, Does.Contain(firstName));
            Assert.That(customer.Greeting, Does.Contain(lastName));
            Assert.That(customer.Greeting, Does.StartWith("Bonjour"));
            Assert.That(customer.Greeting, Does.EndWith(lastName));
        }

        [Test]
        public void GreetCustomer_InputNoNames_ReturnNullGreeting()
        {
            Assert.That(customer.Greeting, Is.Null);
        }
    }
}