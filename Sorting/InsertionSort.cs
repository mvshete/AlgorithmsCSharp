namespace Algorithms.Sorting
{
  public class InsertionSort
  {
    public static void PerformInsertionSort(int[] array)
    {
      Helper.Print(array, "Insertion Sort", false);

      int arraySize = array.Length;

      for (var pass = 0; pass < arraySize; pass++)
      {
        var temp = array[pass];
        var leftmostUnsortedElementIndex = pass;

        for (; leftmostUnsortedElementIndex > 0; leftmostUnsortedElementIndex--)
        {
          if (array[leftmostUnsortedElementIndex - 1] > temp)
            array[leftmostUnsortedElementIndex] = array[leftmostUnsortedElementIndex - 1];
          else
            break;
        }
        array[leftmostUnsortedElementIndex] = temp;
      }

      Helper.Print(array, "Insertion Sort", false);
    }
  }
}