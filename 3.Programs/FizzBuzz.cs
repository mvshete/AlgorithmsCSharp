using System.Text;

namespace Algorithms.Programs
{
    public class FizzBuzz
    {
        public static string GetFizzBuzz(int range)
        {
            StringBuilder fizzString = new StringBuilder();

            for (int i = 1; i <= range; i++)
            {               
                 if ((i % 3 == 0) && (i % 5 == 0))
                {
                    fizzString.Append("FizzBuzz" + " ");
                }
                else if (i % 3 == 0)
                {
                    fizzString.Append("Fizz" + " ");                   
                }
                else if (i % 5 == 0)
                {
                    fizzString.Append("Buzz" + " ");                    
                }               
                else
                {
                    fizzString.Append(i + " ");                   
                }
            }

            return fizzString.ToString();
        }
    }
}
