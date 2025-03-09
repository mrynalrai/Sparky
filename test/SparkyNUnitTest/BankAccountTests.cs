using Moq;
using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class BankAccountTests
    {
        public required BankAccount bankAccount;
        public required Mock<ILogBook> logBookMock;

        [SetUp]
        public void Init()
        {
            // Arrange
            // bankAccount = new (new LogBook());  // This is not unit testing anymore. In addition to 'BankAccount', we are also testing 'LogBook'. Hence this is integration testing          
            logBookMock = new Mock<ILogBook>();
            logBookMock.Setup(l => l.Log(It.IsAny<string>()));
            logBookMock.Setup(l => l.LogToDb(It.IsAny<string>())).Returns(true);
            logBookMock.Setup(l => l.LogBalanceAfterWithdrawal(true, It.IsAny<double>())).Returns(true);
            logBookMock.Setup(l => l.LogBalanceAfterWithdrawal(false, It.IsAny<double>())).Returns(false);

            bankAccount = new (logBookMock.Object);
        }

        [Test]
        [TestCase(101.1)]
        public void Deposit_DepositDouble_ReturnTrue(double amount)
        {
            // Act
            var result = bankAccount.Deposit(amount);
            // Assert
            Assert.That(result, Is.True);
            Assert.That(bankAccount.GetBalance(), Is.EqualTo(amount));
            logBookMock.Verify(l => l.Log(It.IsAny<string>()), Times.AtLeastOnce, "Log should be called on deposit.");
        }

        [Test]
        [TestCase(500.0, 400.0, ExpectedResult = true)]
        [TestCase(500.0, 600.0, ExpectedResult = false)]
        public bool Withdraw_WithdrawDouble_ReturnCorrectTransactionStatus(double initialBalance, double amount)
        {
            bankAccount.Deposit(initialBalance);
            var result = bankAccount.Withdraw(amount);
            logBookMock.Verify(l => l.LogBalanceAfterWithdrawal(It.IsAny<bool>(), It.IsAny<double>()), Times.AtLeastOnce, "LogBalanceAfterWithdrawal should be called on Withdraw.");
            return result;
        }
    }
}