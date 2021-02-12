using System;
using System.Collections.Generic;
using System.Linq;

namespace MyConsoleApp
{
    public class Func_T_TResult__Delegate
    {
        static Func<string, string> selector = str => str.ToUpper(); // A lambda expression is assigned to a Func variable (delegate)
        static List<string> words =new List<string>() { "orange","apple", "Article", "elephant" };

        public static void ConvertToUppercase() {
            var wordsInUppercase = words.Select(selector).ToList();  // Select takes a delegate

            wordsInUppercase.ForEach(word => {
                Console.WriteLine(word);
            });
        }

        static Func<string[], int> countWords = strArray => strArray.Count();
        static int countOfWords = countWords(new string[] { "Hello", "Saturday", "Sunday" });
        public static void PrintCountOfWords() {
            Console.WriteLine(string.Format("Number of words: {0}", countOfWords));
        }

        static Func<int, int, string> addTwoInts = (int x, int y) => { 
            var sum = x + y; 
            return string.Format("Sum is {0}",sum); 
        };

        public static void AddTwoInts(int x, int y) {
            Console.Write(addTwoInts(x,y));
        }
       


    }

}
