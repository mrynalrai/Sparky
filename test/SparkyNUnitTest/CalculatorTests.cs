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
        public void AddNumbers_InputTwoNumbers_ReturnCorrectSum()
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
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(-3)]
        public void IsOddNumber_InputOddNumber_ReturnTrue(int num)
        {
            Calculator calculator = new ();
            bool result = calculator.IsOddNumber(num);
            Assert.That(result, Is.EqualTo(true));
            ClassicAssert.IsTrue(result);
        }

        [Test]
        [TestCase(0)]
        [TestCase(2)]
        [TestCase(-2)]
        public void IsOddNumber_InputEvenNumber_ReturnFalse(int num)
        {
            Calculator calculator = new ();
            bool result = calculator.IsOddNumber(num);
            Assert.That(result, Is.EqualTo(false));
            ClassicAssert.False(result);
        }

        [Test]
        [TestCase(4, ExpectedResult = false)]
        [TestCase(7, ExpectedResult = true)]
        public bool IsOddNumber_InputNumber_ReturnTrueIfOdd(int num)
        {
            Calculator calculator = new ();
            bool result = calculator.IsOddNumber(num);
            return result;
        }
    }
}