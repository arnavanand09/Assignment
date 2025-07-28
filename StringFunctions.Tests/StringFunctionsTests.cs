using NUnit.Framework;
using Assignment11;
using System.Collections.Generic;
using static Assignment11.StringFunctionsLib;


namespace StringFunctions.Tests
{
    public class StringFunctionsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            Assert.IsTrue(StringFunctionsLib.IsPalindrome("madam"));
            Assert.IsFalse(StringFunctionsLib.IsPalindrome("manav"));
        }

        [Test]
        public void ReverseText_ReversesCorrectly()
        {
            Assert.AreEqual("dlroW olleH", StringFunctionsLib.ReverseText("Hello World"));
        }

        [Test]
        public void CountWords_CountsCorrectly()
        {
            Assert.AreEqual(4, StringFunctionsLib.CountWords("This is a test"));
        }
    
        [Test]
        public void ToUpperCase_ConvertsToUpperCase()
        {
            Assert.AreEqual("HELLO WORLD", StringFunctionsLib.ConvertToUpper("hello world"));
        }
        [Test]
        public void ToProperCase_ConvertsToProperCase()
        {
            Assert.AreEqual("Hello World", StringFunctionsLib.ConvertToProperCase("hello world"));
        }
        [Test]
        public void CombineWith_CombinesStrings()
        {
            Assert.AreEqual("Hello World This is a test", StringFunctionsLib.CombineTexts("Hello World", "This is a test"));
        }

        [Test]
        public void RemoveExtraSpaces_RemovesExtraSpaces()
        {
            Assert.AreEqual("Hello World", StringFunctionsLib.RemoveExtraSpaces("   Hello   World   "));
        }
        [Test]
        public void ContainsSubstring_FindsSubstring()
        {
            Assert.IsTrue(StringFunctionsLib.ContainsSubstring("Hello World", "World"));
            
        }
    }
}