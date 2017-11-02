using System;

namespace Algorithms.Sorting
{
  public class SelectionSort
  {
    public static void PerformSelectionSort(int[] array)
    {
      Helper.Print(array, "Selection Sort", true);

      int arraySize = array.Length;

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

      Helper.Print(array, "Selection Sort", false);
    }

  }
}