
namespace Algorithms.Programs
{
    public class GcdLcd
    {
        public static int GetGcd(int number1, int number2)
        {
            while (number1 != number2)
            {
                if (number1 > number2)
                {
                    number1 = number1 - number2;
                }
                if (number2 > number1)
                {
                    number2 = number2 - number1;
                }                
            }
            return number1;
        }

        public static int GetLcm(int number1, int number2)
        {
            return (number1 * number2) / GetGcd(number1,number2);
        }

        public static int GcdRecursive(int number1, int number2)
        {
            if (number1 == 0)
            {
                return number2;
            }
            if (number2 == 0)
            {
                return number1;
            }

            if (number1 > number2)
            {
                return GcdRecursive(number1 % number2, number2);
            }
            else
            {
                return GcdRecursive(number1, number2 % number1);
            }
        }
    }
}
