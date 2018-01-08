using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Programs
{
    public class Factorial
    {
        public static int SimpleFactorial(int number)
        {
            int facto = number;

            for (int i = number - 1; i >= 1; i--)
            {
                facto = facto * i;
            }

            return facto;
        }

        public static int RecursionFactorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * RecursionFactorial(number - 1);
        }

        public static int RecursionUsingWhileLoop(int number)
        {
            int result = 1;

            while (number !=1)
            {
                result = result * number;
                number--;
            }
            return result;
        }
    }
}
