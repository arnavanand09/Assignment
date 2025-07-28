using Assignment11;
using NUnit.Framework;
using static Assignment11.NumericFunctionsLib;


namespace NumericFunctionsLibrary.Tests
{
    public class NumericFunctionsTests
    {
    
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddNumbers_AddsCorrectly()
        {
          
            Assert.AreEqual(6, NumericFunctionsLib.AddNumbers(1,2,3));
            Assert.AreEqual(20, NumericFunctionsLib.AddNumbers(5,6,9));
        }
        [Test]
        public void SubtractNumbers_SubtractsCorrectly()
        {
         
            Assert.AreEqual(-1, NumericFunctionsLib.SubtractNumbers(2, 3));
        }
        [Test]
        public void MultiplyNumbers_MultipliesCorrectly()
        {
            Assert.AreEqual(90, NumericFunctionsLib.MultiplyNumbers(10, 9));
        }

        [Test]
        public void IsEven_EvenNumber_ReturnsTrue()
        {
            Assert.IsTrue(NumericFunctionsLib.IsEven(10));
            Assert.IsFalse(NumericFunctionsLib.IsEven(7));
        }

        [Test]
        public void IsOdd_WithNumbers_ReturnsCorrectResult()
        {
            Assert.IsTrue(NumericFunctionsLib.IsOdd(7));
            Assert.IsFalse(NumericFunctionsLib.IsOdd(10));
        }



        [Test]
        public void IsPrime_PrimeNumber_ReturnsTrue()
        {
            Assert.IsTrue(NumericFunctionsLib.IsPrime(7));
            Assert.IsFalse(NumericFunctionsLib.IsPrime(10));
        }

        [Test]
        public void GetEvenNumbers_InRange_ReturnsEvenNumbers()
        {
            CollectionAssert.AreEqual(new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, NumericFunctionsLib.GetEvenNumbers(1, 20));
        }

        [Test]
        public void GetOddNumbers_InRange_ReturnsOddNumbers()
        {
            CollectionAssert.AreEqual(new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }, NumericFunctionsLib.GetOddNumbers(1, 20));
        }

        [Test]
        public void GetPrimeNumbers_InRange_ReturnsPrimeNumbers()
        {
            CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 7, 11, 13, 17, 19 }, NumericFunctionsLib.GetPrimeNumbers(1, 20));
        }


        [Test]
        public void GenerateMultiplicationTable_ReturnsCorrectTable()
        {
            string expected = "5 × 1 = 5\n" +
                              "5 × 2 = 10\n" +
                              "5 × 3 = 15\n" +
                              "5 × 4 = 20\n" +
                              "5 × 5 = 25\n" +
                              "5 × 6 = 30\n" +
                              "5 × 7 = 35\n" +
                              "5 × 8 = 40\n" +
                              "5 × 9 = 45\n" +
                              "5 × 10 = 50\n";

            Assert.AreEqual(expected, NumericFunctionsLib.GenerateMultiplicationTable(5));
        }

        [Test]
        public void ReverseNumber_ReversesCorrectly()
        {

            Assert.AreEqual(54321, NumericFunctionsLib.ReverseNumber(12345));
        }

    }
}