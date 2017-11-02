using System;

public static class Helper
{
  public static void Print(int[] array, string algorithmName, bool isOriginal)
  {

    var message = isOriginal ? string.Format("\n{0} :: Original Array", algorithmName) :
                               string.Format("\n{0} :: Sorted Array", algorithmName);
    Console.WriteLine(message);

    foreach (var item in array)
    {
      Console.Write(item + " ");
    }
  }
}