using System;
namespace Algorithms.Sorting
{
  public class HeapSort
  {
    public static void PerformHeapSort(int[] array)
    {     
      int arraySize = array.Length;

      Console.WriteLine("Heap Sort :: Original Array");

      foreach (var item in array)
      {
        Console.Write(item + " ");
      }

      // Build max heap
      for (int index = arraySize / 2 - 1; index >= 0; index--)
      {
        Heapify(ref array,arraySize, index);
      }


      // Heap sort
      for (int index = arraySize - 1; index >= 0; index--)
      {
        int temp = array[0];
        array[0] = array[index];
        array[index] = temp;
                
        // Heapify root element
        Heapify(ref array, index, 0);
      }

      Console.WriteLine("\nHeap Sort :: Sorted Array");

      foreach (var item in array)
      {
        Console.Write(item + " ");
      }
    }

    private static void Heapify(ref int[] array, int n, int i)
    {
      // Find largest among root, left child and right child
      int largest = i;
      int left = 2 * i + 1;
      int right = 2 * i + 2;

      if (left < n && array[left] > array[largest])
        largest = left;

      if (right < n && array[right] > array[largest])
        largest = right;

      // Swap and continue heapifying if root is not largest
      if (largest != i)
      {
        int swap = array[i];
        array[i] = array[largest];
        array[largest] = swap;

        Heapify(ref array, n, largest);
      }
    }

  }
}