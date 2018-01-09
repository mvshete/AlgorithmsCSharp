using System.Collections.Generic;
using System.Linq;


//Find missing number in a sequence  


namespace Algorithms.Numbers
{
  public class MissingNumber
  {
    public static int[] FindMissingNumber(int[] array, int range)
    {
      List<int> numbers = new List<int>();
      List<int> newArray = new List<int>();

      for (int i = 0; i < array.Length; i++)
      {
        numbers.Add(array[i]);
      }

      for (int i = 1; i < range; i++)
      {
        if (!numbers.Contains(i))
        {
          newArray.Add(i);
        }
      }

      return newArray.ToArray();
    }

    public static int[] FindMissingNumberUsingLinq(int[] array, int range)
    {
      List<int> newArray = new List<int>();

      for (int i = 1; i < range; i++)
      {
        if (!array.Contains(i))
        {
          newArray.Add(i);
        }
      }
      return newArray.ToArray();
    }
  }
}