/*

An Armstrong number of three digits is an integer such that the
sum of the cubes of its digits is equal to the number itself.
For example, 371 is an Armstrong number since 3**3 + 7**3 + 1**3 = 371
*/

namespace Algorithms.Programs
{
    public class Armstrong
    {
        public static bool IsArmstrongNumber(int number)
        {           
            int reminder = 0;
            int sum = 0;

            for (int i = number; i > 0 ; i = i/10)
            {
                reminder = i % 10;
                sum = sum + reminder * reminder * reminder;
            }

            if (sum == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
