using Moq;
using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class BankAccountTests
    {
        public required BankAccount bankAccount;
        public required ILogBook logBook;

        [SetUp]
        public void Init()
        {
            logBook = new Mock<ILogBook>().Object;
            // Arrange
            // bankAccount = new (new LogBook());  // This is not unit testing anymore. In addition to 'BankAccount', we are also testing 'LogBook'. Hence this is integration testing
            bankAccount = new (logBook);
        }

        [Test]
        [TestCase(101.1)]
        public void Deposit_DepositDouble_ReturnTrue(double amount)
        {
            // Act
            var result =  bankAccount.Deposit(amount);
            // Assert
            Assert.That(result, Is.True);
            Assert.That(bankAccount.GetBalance(), Is.EqualTo(amount));
        }
    }
}