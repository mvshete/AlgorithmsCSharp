using System;

namespace Algorithms.Numbers
{
  public class MergeArray
  {
    public static void MergeArrays()
    {
      int[] firstArray = new int[10];

      for (int i = 0; i < 5; i++)
      {
        firstArray[i] = i + 1;
      }

      int[] secondArray = { 9, 10, 8 };

      int firstArrayIndex = 5;
      int secondArrayIndex = secondArray.Length - 1;
      int mergedIndex = firstArray.Length - 1;

      while (secondArrayIndex >= 0)
      {
        if (secondArray[secondArrayIndex] > firstArray[firstArrayIndex])
        {
          firstArray[mergedIndex] = secondArray[secondArrayIndex];
          secondArrayIndex--;
        }
        else if (secondArray[secondArrayIndex] < firstArray[firstArrayIndex])
        {
          firstArray[mergedIndex] = firstArray[firstArrayIndex];
          firstArrayIndex--;
        }
        mergedIndex--;
      }

      for (int i = 0; i < firstArray.Length; i++)
      {
        Console.Write(firstArray[i] + " ");
      }

    }
  }
}