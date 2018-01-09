using System.Collections.Generic;

//Determine if a string has all unique characters

namespace Algorithms.Strings
{
    public class UniqueChars
    {
        public static bool IsUnique(string word)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (chars.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    chars.Add(c, 1);
                }
            }
            return true;
        }

        public static bool IsUniqueUsingLoop(string word)
        {
            string temp1 = string.Empty;
            string temp2 = string.Empty;

            for (int i = 0; i < word.Length; i++)
            {
                temp1 = word.Substring(i, 1);

                for (int j = 0; j < word.Length; j++)
                {
                    temp2 = word.Substring(j, 1);

                    if ( (temp1==temp2) && (i != j))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
