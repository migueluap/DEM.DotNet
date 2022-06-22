using NUnit.Framework;

namespace DEM.DotNet.Algorithm.Test
{
    public class ExerciseTests
    {
        private Exercise? _exercise { get; set; }
        [SetUp]
        public void Setup()
        {
            _exercise = new Exercise();
        }

        [TestCase(123456)]
        [TestCase(859634)]
        [TestCase(111111)]
        [TestCase(134567)]
        public void ValidateRandomNumber_EqualTest(int randomNumber) 
        {
            //Assign
            //int randomNumber = 125486;
            //Act
            string outcome = _exercise?.ValidateRandomNumber(randomNumber);

            //Assert
            Assert.AreEqual("Correct", outcome);
        }



        //[Test]
        //[TestCase("10011")]
        [TestCase("100101")]
        public void BinaryToDecimal_EqualTest(string binaryInput)
        {
            //Assign
            //var binaryInput = "10011";
            //Act
            var decimalOutPut = _exercise?.BinaryToDecimal(binaryInput);
            //Assert
            Assert.AreEqual(37, decimalOutPut);
            //Assert.AreEqual(19, decimalOutPut);
        }

        [Test]
        public void Factorial_EqualTest()
        {   //Assign
            var numberInput = 4;
            //Act
            var factorial = _exercise?.Factorial(numberInput);
            //Assert
            Assert.AreEqual(24, factorial);

        }

        [Test]
        public void Fibonacci_EqualTest()
        {   //Assign
            var positionNumber = 6;
            //Act
            var fibonacciNumber = _exercise?.Fibonacci(positionNumber);
            //Assert
            Assert.AreEqual(13, fibonacciNumber);

        }



    }
}