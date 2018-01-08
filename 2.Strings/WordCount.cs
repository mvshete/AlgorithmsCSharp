/*
   Count number of words in a string
*/
namespace Algorithms.Strings
{
    public class WordCount
    {
        public static int GetWordCount(string sentence)
        {
            int result = 0;

            sentence = sentence.Trim();

            if (sentence.Length == 0)
            {
                return 0;                
            }

            foreach (var word in sentence.Split(' '))
            {
                result++;
            }

            return result;
        }
    }
}
