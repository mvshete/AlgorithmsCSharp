/*
    reverse a string
    Also
    String Palindrome
*/
using System;
using System.Text;

namespace Algorithms.Strings
{
    public class StringReverse
    {
        public static void ReverseString(string originalString)
        {
            string reverseString = string.Empty;

            int originalStringLength = originalString.Length - 1;

            while (originalStringLength >= 0)
            {
                reverseString = reverseString + originalString[originalStringLength];
                originalStringLength--;
            }

            Console.WriteLine("Reverse String : " + reverseString);
        }

        public static void ReverseStringUsingStringBuilder(string originalString)
        {
            StringBuilder reverseString = new StringBuilder();
          
            for (int i = (originalString.Length - 1); i >=0; i--)
            {
                reverseString.Append(originalString[i]);
            }

            Console.WriteLine("Reverse String using StringBuilder: " + reverseString.ToString());
        }
    }
}
