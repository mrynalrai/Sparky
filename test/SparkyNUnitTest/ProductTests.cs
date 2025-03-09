using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class ProductTests
    {
        public required Product product;
        [SetUp]
        public void Init()
        {
            product = new Product("Apple", 50.0);
        }
        [Test]
        [TestCase(true, 40.0)]
        [TestCase(false, 50.0)]
        public void GetPrice_InputPlatinumCustomer_ReturnCorrectPrice(bool isPlatinum, double expectedPrice)
        {
            var platinumCustomer = new Customer() { IsPlatinum = isPlatinum }; // You should not create interface just for the purpose of testing
            var result = product.GetPrice(platinumCustomer);
            Assert.That(result, Is.EqualTo(expectedPrice));
        }
    }
}