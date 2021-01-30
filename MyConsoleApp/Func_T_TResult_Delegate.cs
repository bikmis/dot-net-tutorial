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
    }
}
