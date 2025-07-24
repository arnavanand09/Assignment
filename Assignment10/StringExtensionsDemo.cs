using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
public static class StringExtensions
    {
        public static int CharacterCount(this string input)
        {
            if (input == null) return 0;
            return input.Replace(" ", "").Length;
        }

        public static bool IsPalindrome(this string input)
        {
            if (input == null) return false;
            string cleaned = input.Replace(" ", "").ToLower();
            char[] arr = cleaned.ToCharArray();
            Array.Reverse(arr);
            return cleaned == new string(arr);
        }

        public static string ReverseSentence(this string input)
        {
            if (input == null) return "";
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static void CountCharacters(this string input, out int vowels, out int consonants, out int digits, out int specials)
        {
            vowels = consonants = digits = specials = 0;
            if (input == null) return;

            string cleaned = input.Replace(" ", "").ToLower();

            foreach (char c in cleaned)
            {
                if ("aeiou".Contains(c))
                    vowels++;
                else if (char.IsLetter(c))
                    consonants++;
                else if (char.IsDigit(c))
                    digits++;
                else
                    specials++;
            }
        }

        public static string ToUpperCase(this string input)
        {
            return input?.ToUpper();
        }

        public static string ToProperCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "";
            string[] words = input.ToLower().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            return string.Join(" ", words);
        }

        public static string CombineWith(this string input, string other)
        {
            return (input ?? "") + " " + (other ?? "");
        }

        public static string RemoveExtraSpaces(this string input)
        {
            if (input == null) return "";
            string[] parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", parts);
        }

        public static int WordCount(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;
            return input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool ContainsSubstring(this string input, string substring)
        {
            if (input == null || substring == null) return false;
            return input.IndexOf(substring, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public static int CountSubstringOccurrences(this string input, string substring)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(substring)) return 0;

            int count = 0, index = 0;
            while ((index = input.IndexOf(substring, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += substring.Length;
            }
            return count;
        }
    }

    class StringExtensionsDemo
    {
        static void Main()
        {
            string sentence = " Random Sentence  ";

            Console.WriteLine("Character Count: " + sentence.CharacterCount());
            Console.WriteLine("Is Palindrome: " + sentence.IsPalindrome());
            Console.WriteLine("Reversed Sentence: " + sentence.ReverseSentence());

            sentence.CountCharacters(out int vowels, out int consonants, out int digits, out int specials);
            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}, Digits: {digits}, Specials: {specials}");

            Console.WriteLine("Upper Case: " + sentence.ToUpperCase());
            Console.WriteLine("Proper Case: " + sentence.ToProperCase());
            Console.WriteLine("Combined: " + sentence.CombineWith("This is a second part."));
            Console.WriteLine("Without Extra Spaces: [" + sentence.RemoveExtraSpaces() + "]");
            Console.WriteLine("Word Count: " + sentence.WordCount());
            Console.WriteLine("Contains 'teach': " + sentence.ContainsSubstring("teach"));
            Console.WriteLine("Occurrences of 'a': " + sentence.CountSubstringOccurrences("a"));
        }
    }

}

