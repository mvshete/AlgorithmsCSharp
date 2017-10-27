using System;
namespace Algorithms.Sorting
{
  public class HeapSort
  {
    public static void PerformHeapSort(int[] arr)
    {     
      int n = arr.Length;

      Console.WriteLine("Heap Sort :: Original Array");

      foreach (var item in arr)
      {
        Console.Write(item + " ");
      }

      // Build max heap
      for (int i = n / 2 - 1; i >= 0; i--)
      {
        Heapify(ref arr, n, i);
      }


      // Heap sort
      for (int i = n - 1; i >= 0; i--)
      {
        int temp = arr[0];
        arr[0] = arr[i];
        arr[i] = temp;

        // Heapify root element
        Heapify(ref arr, i, 0);
      }

      Console.WriteLine("\nHeap Sort :: Sorted Array");

      foreach (var item in arr)
      {
        Console.Write(item + " ");
      }
    }

    private static void Heapify(ref int[] arr, int n, int i)
    {
      // Find largest among root, left child and right child
      int largest = i;
      int l = 2 * i + 1;
      int r = 2 * i + 2;

      if (l < n && arr[l] > arr[largest])
        largest = l;

      if (r < n && arr[r] > arr[largest])
        largest = r;

      // Swap and continue heapifying if root is not largest
      if (largest != i)
      {
        int swap = arr[i];
        arr[i] = arr[largest];
        arr[largest] = swap;

        Heapify(ref arr, n, largest);
      }
    }

  }
}