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
    }
}