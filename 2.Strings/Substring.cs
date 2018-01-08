/*
    find all substrings in a string
    All probabalities

*/
using System;

namespace Algorithms.Strings
{
    public class Substring
    {
        public static void AllSubstringsInString(string word)
        {
            for (int length = 0; length < word.Length; length++)
            {
                for (int start = 0; start <= word.Length - length; start++)
                {
                    string substring = word.Substring(start,length);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
