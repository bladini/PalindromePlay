using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPalindrome
{
    public class PalindromeFinder
    {
        public bool IsPalindrome(string value)
        {
            if (value == null)
                throw new ArgumentNullException("Error: Value must not be null.");
            if (value.Length <= 1)
                throw new ArgumentException("Error: Input must have more than 1 characters.");

            //if (value.Equals("rotator"))
            //    isPalindromeValue = true;

            var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            var reversedValue = new String(charArray);

            return (reversedValue == value);
        }

    }
}
