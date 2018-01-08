/*
   return highest occurred character in a String
*/
using System;
using System.Collections.Generic;

namespace  Algorithms.Strings
{
    public class HighestChars
    {
        public static void GetHighestChars(string word)
        {
            int max = 0;
            string character = string.Empty;
            Dictionary<string, int> data = new Dictionary<string, int>();

            foreach (char c in word.ToLower().Trim())
            {
                if (!data.ContainsKey(c.ToString()))
                {
                    data.Add(c.ToString(), 1);
                }
                else
                {
                    data[c.ToString()] = Convert.ToInt32(data[c.ToString()] + 1);
                }
            }

            foreach (var item in data)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    character = item.Key;
                }
            }

            Console.WriteLine("Characters {0}  is highest occured character with count {1} ",
                character, max);

        }
    }
}
