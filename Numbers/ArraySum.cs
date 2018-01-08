using System;

//Given an integer and an array of integers determine whether any two integers
//in the array sum to that integer.
namespace Algorithms.Numbers
{
  public class ArraySum
  {
    public static void GetArraySum()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target = 10;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j)
                    {
                        int sum = array[i] + array[j];
                        if (sum == target)
                        {
                            Console.WriteLine("Sum of {0} & {1} is equal to  {2}",
                             array[i], array[j], target);
                        }
                    }
                }
            }
        }
  }
}