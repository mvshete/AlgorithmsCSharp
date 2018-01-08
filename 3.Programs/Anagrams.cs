/*
    Determine if Two Words Are Anagrams of Each Other
    Two words are said to be Anagrams of each other if they share the same 
    set of letters to form the respective words.
    
    for an example: Silent–>Listen, post–>opts.
*/

using System;
using System.Linq;

namespace Algorithms.Programs
{
    public class Anagrams
    {
        public static void IsAnagram(string firstWord, string secondWord)
        {
            char[] char1 = firstWord.ToLower().ToCharArray();
            char[] char2 = secondWord.ToLower().ToArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string newWord1 = new string(char1);
            string newword2 = new string(char2);

            if (newWord1 == newword2)
            {
                Console.WriteLine("Strings are Anagram");
            }
            else
            {
                Console.WriteLine("Strings are not Anagram");
            }

        }
    }
}
