namespace Sparky.MSTest
{
    [TestClass]
    // {ClassUnderTest}Tests
    public class CalculatorTests
    {
        [TestMethod]
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