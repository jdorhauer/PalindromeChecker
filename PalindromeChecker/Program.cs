using System;
using System.Linq;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or phrase:");
            string word = Console.ReadLine().ToLower();
            Console.WriteLine($"That {(IsPalindrome(word) ? "is" : "is not")} a palindrome.");
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }

        private static bool IsPalindrome(string word)
        {
            return new string(word.Reverse().ToArray()) == word;
        }
    }
}
