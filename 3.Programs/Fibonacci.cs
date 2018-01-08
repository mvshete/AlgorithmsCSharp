using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Programs
{
    public class Fibonacci
    {
        public static int NthFibonacciNumber(int range)
        {
            if (range == 0 || range == 1)
            {
                return range;
            }
            else
            {
                return (NthFibonacciNumber(range - 1) + NthFibonacciNumber(range - 2));
            }
        }

        public static int[] FibSeriesSimple(int range)
        {
            List<int> fibList = new List<int>();
            fibList.Add(0);
            fibList.Add(1);

            int firstNumber = 0;
            int secondNumber = 1;

            int result = 0;

            if (range == 0 || range == 1)
            {
                return fibList.ToArray();
            }

            for (int i = 2; i <= range; i++)
            {
                result = firstNumber + secondNumber;
                fibList.Add(result);
                firstNumber = secondNumber;
                secondNumber = result;

            }
            return fibList.ToArray();
        }
    }
}
