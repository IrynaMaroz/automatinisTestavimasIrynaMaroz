using Calculator;
using NUnit.Framework;

namespace CalculatorUnitTests
{
    public class Tests
    {
        [Test]
        public void TestSum() 
        {
            // Arrange (Testo duomenys)
            int number1 = 5;
            int number2 = 2;
            int expectedResult = 7;

            // Act (Testo veiksmai)
            int actualResult = Methods.Sum(number1, number2);

            // Assert (Testo rezultatu palyginimas)
            Assert.AreEqual(expectedResult, actualResult);
            //Assert.IsTrue(actualResult == expectedResult);
        }
        [Test]
        public void TestDivision()
        {
            // Arrange (Testo duomenys)
            int number1 = 5;
            int number2 = 2;
            double expectedResult = 2.5;

            // Act (Testo veiksmai)
            double actualResult = Methods.Divide(number1, number2);

            // Assert (Testo rezultatu palyginimas)
            Assert.AreEqual(expectedResult, actualResult);
            //Assert.IsTrue(actualResult == expectedResult);
        }
    }
}
