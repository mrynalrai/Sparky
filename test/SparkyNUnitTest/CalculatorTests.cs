using NUnit.Framework;
using NUnit.Framework.Legacy;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]   // Marks a class as a test fixture and may provide inline constructor arguments.
    // {ClassUnderTest}Tests
    public class CalculatorTests
    {
        [Test]  // Marks a method of a TestFixture that represents a test.
        // MethodUnderTest_Scenario_ExpectedResult()
        public void AddNumbers_InputTwoIntegers_ReturnCorrectSum()
        {
            // Arrange
            Calculator calculator = new ();
    
            // Act
            int result = calculator.AddNumbers(10, 20);
            
            // Assert
            Assert.That(30, Is.EqualTo(result));    // Contraint Model
            ClassicAssert.AreEqual(30, result);;    // Classic Model
        }

        [Test]
        public void IsOddNumber_InputOddInteger_ReturnTrue()
        {
            Calculator calculator = new ();
            bool result = calculator.IsOddNumber(5);
            Assert.That(result, Is.EqualTo(true));
            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void IsOddNumber_InputEvenInteger_ReturnFalse()
        {
            Calculator calculator = new ();
            bool result = calculator.IsOddNumber(4);
            Assert.That(result, Is.EqualTo(false));
            ClassicAssert.False(result);
        }
    }
}