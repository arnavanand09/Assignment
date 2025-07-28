using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class StringFunctionsLib
    {
        public static int CountCharacters(string text)
        {
            return text.Length;
        }

        public static bool IsPalindrome(string text)
        {
            
            string cleanText = "";
            foreach (char c in text)
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleanText += char.ToLower(c);
                }
            }

            int left = 0;
            int right = cleanText.Length - 1;

            while (left < right)
            {
                if (cleanText[left] != cleanText[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        public static string ReverseText(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static Dictionary<string, int> AnalyzeText(string text)
        {
            int vowels = 0;
            int consonants = 0;
            int digits = 0;
            int specialChars = 0;
            string vowelLetters = "aeiouAEIOU";

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    digits++;
                }
                else if (char.IsLetter(c))
                {
                    if (vowelLetters.Contains(c))
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
                else
                {
                    specialChars++;
                }
            }

            return new Dictionary<string, int>
            {
                { "Vowels", vowels },
                { "Consonants", consonants },
                { "Digits", digits },
                { "Special Characters", specialChars }
            };
        }


        public static string ConvertToUpper(string text)
        {
            return text.ToUpper();
        }

        public static string ConvertToProperCase(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            string[] words = text.Split(' ');
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    result.Append(char.ToUpper(word[0]));
                    if (word.Length > 1)
                    {
                        result.Append(word.Substring(1).ToLower());
                    }
                    result.Append(' ');
                }
            }

            return result.ToString().Trim();
        }



        public static string CombineTexts(string text1, string text2)
        {
            return text1 + " " + text2;
        }

        public static string RemoveExtraSpaces(string text)
        {
            text = text.Trim();
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            return text;
        }
        public static int CountWords(string text)
        {
            text = RemoveExtraSpaces(text);
            if (string.IsNullOrEmpty(text))
                return 0;

            return text.Split(' ').Length;
        }
        public static bool ContainsSubstring(string text, string substring)
        {
            return text.Contains(substring);
        }

        public static int CountSubstringOccurrences(string text, string substring)
        {
            int count = 0;
            int index = 0;

            while ((index = text.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }

            return count;
        }

    }
}
