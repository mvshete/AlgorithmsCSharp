using System;

namespace Algorithms.Sorting
{
  public class BubbleSort
  {
    public static void PerformBubbleSort(int[] array)
    {    
      Console.WriteLine("Bubble Sort :: Original Array");

      foreach (var item in array)
      {
          Console.Write(item +" ");
      }

      for (int pass = 0; pass <= array.Length-2; pass++)
      {
          for (int i = 0; i <= array.Length-2; i++)
          {
              if (array[i]>array[i+1])
              {
                  array[i] = array[i]+ array[i+1];
                  array[i+1] = array[i]-array[i+1];
                  array[i] = array[i]-array[i+1];
              }
          }
      }

      Console.WriteLine("\nBubble Sort :: Sorted Array");

      foreach (var item in array)
      {
          Console.Write(item +" ");
      }

    }
  }
}