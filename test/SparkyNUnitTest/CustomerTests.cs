using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        [TestCase("Jon", "Snow")]
        [TestCase("Sansa", "Stark")]
        public void GreetCustomer_InputNames_ReturnCorrectGreeting(string firstName, string lastName)
        {
            Customer customer = new ();
            string result = customer.GreetCustomer(firstName, lastName);
            Assert.That(result, Does.Contain(firstName));
            Assert.That(result, Does.Contain(lastName));
            Assert.That(result, Does.StartWith("Bonjour"));
            Assert.That(result, Does.EndWith(lastName));
        }
    }
}