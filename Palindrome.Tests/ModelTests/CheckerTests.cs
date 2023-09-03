using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;
// using System.Collections.Generic;
using System;

namespace Palindrome.Tests
{
  [TestClass]
  public class CheckerTests
  {
    [TestMethod]
    public void IsPalindrome_PalindromeString_ReturnsTrue()
    {
      //Arrange
      string validPalindrome = "civic";
      Checker checker = new Checker();
      
      //Act
      bool result = Checker.validPalindrome(validPalindrome);

      //Assert
      Assert.IsTrue(result);
    }

    [TestMethod] 
    public void IsPalindrome_PalindromeString_ReturnsFalse()
    {
      //Arrange
      string invalidPalindrome = "hello";
      Checker checker = new Checker();

      //Act
      bool result = Checker.invalidPalindrome(invalidPalindrome);

      //Assert
      Assert.IsTrue(result);
    }

    [TestMethod]

    public void IsPalindrome_PalindromeString_ToLowercase()
    {
      //Arrange
      string lowercasePalindrome = "CIVIC";
      Checker checker = new Checker();

      //Act
      bool result = Checker.validPalindrome(lowercasePalindrome);

      //Assert
      Assert.IsTrue(result);
    }
  }
}
