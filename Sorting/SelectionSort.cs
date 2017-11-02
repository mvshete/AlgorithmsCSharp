using System;

namespace Algorithms.Sorting
{
  public class SelectionSort
  {
    public static void PerformSelectionSort(int[] array)
    {
      int arraySize = array.Length;

      Console.WriteLine("Selection Sort :: Original Array");

      foreach (var item in array)
      {
        Console.Write(item + " ");
      }

      for (var step = 0; step < array.Length; step++)
      {
        for (int i = step + 1; i < array.Length; i++)
        {
          if (array[step] > array[i])
          {
            array[step] = array[step] + array[i];
            array[i] = array[step] - array[i];
            array[step] = array[step] - array[i];
          }
        }
      }

      Console.WriteLine("\n Selection Sort :: Sorted Array");

      foreach (var item in array)
      {
        Console.Write(item + " ");
      }
    }

  }
}