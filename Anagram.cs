using System;
using System.Linq;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "wxyz";
            string text2 = "zyxw";
            Console.WriteLine("Original strings: " + text1 + "  " + text2);
            Console.WriteLine("Check if two said strings are anagrams or not: " + test(text1, text2));
            text1 = "pears";
            text2 = "spare";
            Console.WriteLine("\nOriginal strings: " + text1 + "  " + text2);
            Console.WriteLine("Check if two said strings are anagrams or not: " + test(text1, text2));
            text1 = "stone";
            text2 = "tones";
            Console.WriteLine("\nOriginal strings: " + text1 + "  " + text2);
            Console.WriteLine("Check if two said strings are anagrams or not: " + test(text1, text2));
            text1 = "cat";
            text2 = "rat";
            Console.WriteLine("\nOriginal strings: " + text1 + "  " + text2);
            Console.WriteLine("Check if two said strings are anagrams or not: " + test(text1, text2));
        }

        public static bool test(string text1, string text2)
        {
            string stext1 = String.Concat(text1.ToUpper().OrderBy(c => c));
            string stext2 = String.Concat(text2.ToUpper().OrderBy(c => c));

            if (stext1 == stext2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
