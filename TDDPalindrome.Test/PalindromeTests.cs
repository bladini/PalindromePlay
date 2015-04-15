using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDPalindrome.Test
{
    [TestClass]
    public class PalindromeTests
    {
        private PalindromeFinder _palindromeFinder = null;
        
        [TestInitialize]
        public void InitTest()
        {
            _palindromeFinder = new PalindromeFinder();
        }

        #region Positive Cases
        [TestMethod]
        public void IsPalindromeReturnTrue()
        {
            //Arrange
            string value = "rotator";
            bool expected = true;

            //Act
            bool actual = _palindromeFinder.IsPalindrome(value);

            //Assert
            Assert.AreEqual(expected, actual);


        }
        #endregion Positive Cases

        #region Negative Cases
        [TestMethod]
        public void IsPalindromeReturnFalse()
        {
            //Arrange
            string value = "raggartangenter";
            bool expected = false;

            //Act
            bool actual = _palindromeFinder.IsPalindrome(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsPalindromeThrowsArgumentNullException()
        {
            //Arrange
            string value = null;

            //Act
            bool actual = _palindromeFinder.IsPalindrome(value);

            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsPalindromeThrowsArgumentException()
        {
            //Arrange
            string value = "a";

            //Act
            bool actual = _palindromeFinder.IsPalindrome(value);

        }



        #endregion Negative Cases
    }
}
