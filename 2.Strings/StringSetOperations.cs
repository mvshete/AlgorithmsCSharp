using System;
using System.Linq;
using System.Text;

namespace Algorithms.Strings
{
    public class StringSetOperations
    {
        static string str1 = "This is india where you can live";
        static string str2 = "This is my india where you can live and enjoy";

        public static void SetOperationsUsingLinq()
        {
            var arr1 = str1.Split(' ');
            var arr2 = str2.Split(' ');
            
            var result = arr2.Union(arr1);
            Console.WriteLine("Union of two strings");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }           
            Console.WriteLine("\n");

            result = arr2.Intersect(arr1);
            Console.WriteLine("Intersect of two strings");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            result = arr2.Except(arr1);
            Console.WriteLine("Except(Minus) of two strings");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }            
        }

        public static void SetOperationsWithoutLinq()
        {            
            StringBuilder unionString = new StringBuilder();
            
            Console.WriteLine("Intersect \n");
            foreach (string str in str1.Split(' '))
            {
                if (str2.Contains(str))
                {
                    Console.Write(str + " ");
                    unionString.Append(str + " ");
                }
            }

            Console.WriteLine("\n\nExcept \n");
            foreach (string str in str2.Split(' '))
            {

                if (!str1.Contains(str))
                {
                    Console.Write(str + " ");
                    unionString.Append(str + " ");
                }
            }

            Console.WriteLine("\n\nUnion \n");

            Console.WriteLine(unionString.ToString());
        }

    }
}
