/*
        Reverse a number
        Check Number is Palindrome or not
*/
using System;

namespace Algorithms.Programs
{
    public class Palindrome
    {

        public static void ReverseNumber(int originalNumber)
        {
            int reversedNumber = 0;
            int temp = originalNumber;

            while (originalNumber > 0)
            {
                int reminder = originalNumber % 10;
                reversedNumber = (reversedNumber * 10) + reminder;
                originalNumber = originalNumber / 10;
            }

            Console.WriteLine("Reversed Number : " + reversedNumber);

            if (temp == reversedNumber)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome");
            }
        }
    }
}
