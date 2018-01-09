using System;
//Swap min and max element in integer array

namespace Algorithms.Numbers
{
  public class MinMaxNumbers
  {
    public static void SwapMinMax()
    {
      int[] data = { 9, 5, 3, 1, 4, 8, 100, 56, 2, 8 };

      int min = 0;
      int max = 0;

      for (int i = 0; i < data.Length; i++)
      {
        if (data[min] > data[i])
        {
          min = i;
        }

        if (data[max] < data[i])
        {
          max = i;
        }
      }

      data[min] = data[min] + data[max];
      data[max] = data[min] - data[max];
      data[min] = data[min] - data[max];

      for (int i = 0; i < data.Length; i++)
      {
        Console.Write(data[i] + " ");
      }
    }
  }
}