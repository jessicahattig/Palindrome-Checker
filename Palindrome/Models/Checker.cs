using System.Collections.Generic;
using System;

namespace Palindrome.Models
{
  public class Checker
  {
    public static bool validPalindrome(string input)
    {
      string reversedInput = ReverseString(input);

      return input == reversedInput;
    }
    public static bool invalidPalindrome(string input)
    {
      string reversedInput = ReverseString(input);

      return input != reversedInput;
    }

    private static string ReverseString(string input)
    {
      char[] charArray = input.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray);
    }
    

  }
}

// string cleanedText = RemoveNonAlphanumericAndSpaces(text);

// private static string RemoveNonAlphanumericAndSpaces(string input)
//     {
//         // Remove non-alphanumeric characters and spaces using regex
//         return Regex.Replace(input, "[^a-zA-Z0-9]", "");
//     }