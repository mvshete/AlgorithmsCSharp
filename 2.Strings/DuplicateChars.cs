using System;

/*
    Remove Duplicate characters from String in C#
*/

namespace Algorithms.Strings
{
  public class DuplicateChars
  {

    public static string RemoveDuplicateChars(string originalString)
    {
      string encounterdLetter = string.Empty;
      string result = string.Empty;

      foreach (char c in originalString)
      {
        if (encounterdLetter.IndexOf(c) == -1)
        {
          encounterdLetter += c;
          result += c;
        }
      }

      return result;
    }
  }
}