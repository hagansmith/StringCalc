using NUnit.Framework;
using StringCalculator.App;

namespace StringCalculator.Tests
{

    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void Entering_No_Numbers_Returns_0()
        { 
            var numbers = "";
            var stringCalculator = new Calculator();

            var result = stringCalculator.Add(numbers);
 
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Entering_1_Number_Returns_That_Number()
        {
            var numbers = "1";
            var stringCalculator = new Calculator();

            var result = stringCalculator.Add(numbers);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void Entering_The_Number_2_Returns_2()
        {
            var numbers = "2";
            var stringCalculator = new Calculator();

            var result = stringCalculator.Add(numbers);

            Assert.AreEqual(2, result);
        }
    }
}
