using System;
//determine total ways stairs can be climbed

namespace Algorithms.Programs
{
    public class StairClimbing
    {
        public static int ComboRecursive(int numStairs)
        {
            if (numStairs > 36)
            {
                throw new Exception("Integer Overflow");
            }
            if (numStairs <= 0)
            {
                return 0;
            }
            if (numStairs == 1)
            {
                return 1;
            }
            if (numStairs == 2)
            {
                return 2;
            }

            if (numStairs == 3)
            {
                return 4;
            }

            return ComboRecursive(numStairs - 1) + ComboRecursive(numStairs - 2) + ComboRecursive(numStairs - 3);
        }

        public static int ComboIterative(int numStairs)
        {
            if (numStairs > 36)
            {
                throw new Exception("int overflow");
            }
            if (numStairs <= 0)
            {
                return 0;
            }
            if (numStairs == 1)
            {
                return 1;
            }
            if (numStairs == 2)
            {
                return 2;
            }
            if (numStairs == 3)
            {
                return 4;
            }

            int[] prev = { 1, 2, 4 };

            //we only start caching results if numStairs is more than 3

            int current = 3;

            while (current < numStairs)
            {
                int preTotal = prev[0] + prev[1] + prev[2];
                prev[0] = prev[1];
                prev[1] = prev[2];
                prev[2] = preTotal;
                current++;
                //for (int i = 0; i < prev.Length; i++)
                //{
                //    Console.Write(prev[i] + " ");                                  
                //}
                //Console.WriteLine("\n------------------");
            }
            return prev[2];
        }
    }
}
