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
        //[ExpectedException(typeof(ArgumentNullException))]
        public void IsPalindromeThrowsArgumentNullException()
        {
            //Arrange
            string value = null;

            //Act
            


            try
            {
                bool actual = _palindromeFinder.IsPalindrome(value);

                // If no exception is thrown, then it fails.
                Assert.Fail("Expected ArgumentNullException");
            }
            catch (ArgumentNullException)
            {
                //This is what should happen. No fail.
            }
            catch
            {
                // If another exception is thrown, then it fails.
                Assert.Fail();
            }
            
        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        public void IsPalindromeThrowsArgumentException()
        {
            //Arrange
            string value = "a";

            //Act

            try
            {
                bool actual = _palindromeFinder.IsPalindrome(value);

                Assert.Fail();
            }
            catch (ArgumentException)
            {
                //OK!
            }
            catch
            {
                Assert.Fail();
            }
            

        }



        #endregion Negative Cases


        /*
        #region Impossible Cases
        [TestMethod]
        public void missionImpossible()
        {
            
            //Assert
            Assert.AreEqual(0, 1);


        }
        #endregion Impossible Cases
         */
    }
}
