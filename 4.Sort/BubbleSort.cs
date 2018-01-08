using System;

namespace Algorithms.Sort
{
  public class BubbleSort
  {
    public static void PerformBubbleSort(int[] array)
    {    
      Helper.Print(array,"Bubble Sort", true);

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

      Helper.Print(array,"Bubble Sort", false);

    }
  }
}