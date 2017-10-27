using System;
using Algorithms.Sorting;

namespace AlgorithmsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] array = {23,1,12,6,2};
           BubbleSort.PerformBubbleSort(array);
           Console.WriteLine();
           int[] array1 = {1,12,9,5,6,10};
           HeapSort.PerformHeapSort(array1);
        }
    }
}
