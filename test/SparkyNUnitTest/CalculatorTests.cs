using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    // {ClassUnderTest}Tests
    public class CalculatorTests
    {
        [Test]
        // MethodUnderTest_Scenario_ExpectedResult()
        public void AddNumbers_InputTwoIntegers_ReturnCorrectSum()
        {
            // Arrange
            Calculator calculator = new ();
    
            // Act
            int result = calculator.AddNumbers(10, 20);
            
            // Assert
            Assert.AreEqual(30, result);
        }

        [Test]
        public void IsOddNumber_InputOddInteger_ReturnTrue()
        {
            Calculator calculator = new ();
            bool result = calculator.IsOddNumber(5);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void IsOddNumber_InputEvenInteger_ReturnFalse()
        {
            Calculator calculator = new ();
            bool result = calculator.IsOddNumber(4);
            Assert.That(result, Is.EqualTo(false));
        }
    }
}