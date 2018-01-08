using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Programs
{
    public class PrimeNumbers
    {
        public static void PrintPrimesInRangeUsingLinq(int range)
        {
            Func<int, IEnumerable<int>> primeNumbers =
                 max =>
                 from i in Enumerable.Range(2, max - 1)
                 where Enumerable.Range(2, i - 2).All(j => i % j != 0)
                 select i;

            IEnumerable<int> result = primeNumbers(range);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }

        public static void PrintPrimesNormalway(int range)
        {
            bool isPrime = true;
            List<int> primNumbers = new List<int>();

            for (int i = 2; i <= range; i++)
            {
                for (int j = 2; j <= range; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    primNumbers.Add(i);
                }
                isPrime = true;
            }

            foreach (var item in primNumbers)
            {
                Console.Write(item + " ");
            }
        }

        public static void PrintPrimesSimple(int range)
        {
            for (int i = 2; i < range; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }               
            }          
        }

        private static bool IsPrime(int number)
        {
            bool isPrime = true;
            int factor = number / 2;           

            for (int i = 2; i <= factor; i++)
            {
                if ((number % i)==0)
                {
                    isPrime = false;
                }               
            }

            return isPrime;
        }
    }
}
