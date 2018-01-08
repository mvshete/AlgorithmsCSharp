using System;

namespace Algorithms.Numbers
{
  public class MoveZeros
  {
    public static void MoveZerosToEnd()
    {
      int[] data = { 1, 0, 2, 0, 3, 0, 4, 5, 0, 10 };

      for (int i = 0; i < data.Length; i++)
      {
        if (data[i] == 0)
        {
          MoveZero(data, i);
        }
      }

      for (int i = 0; i < data.Length; i++)
      {
        Console.Write(data[i] + " ");
      }
    }

    private static void MoveZero(int[] data, int index)
    {
      for (int i = index; i < data.Length - 1; i++)
      {
        data[i] = data[i] + data[i + 1];
        data[i + 1] = data[i] - data[i + 1];
        data[i] = data[i] - data[i + 1];
      }
    }
  }
}