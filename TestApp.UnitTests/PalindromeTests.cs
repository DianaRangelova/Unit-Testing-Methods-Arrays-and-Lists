using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> validPalindrome = new List<string> { "radar", "madam", "level" };

        // Act
        bool result = Palindrome.IsPalindrome(validPalindrome);

        // Assert
        Assert.IsTrue(result);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> emptyList = new();

        // Act
        bool result = Palindrome.IsPalindrome(emptyList);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> singleWord = new List<string> { "madam" };

        // Act
        bool result = Palindrome.IsPalindrome(singleWord);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> nonPalindrome = new List<string> { "hello", "didka", "sun" };

        // Act
        bool result = Palindrome.IsPalindrome(nonPalindrome);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> mixedCase = new List<string> { "radaR", "maDam", "Level" };

        // Act
        bool result = Palindrome.IsPalindrome(mixedCase);

        // Assert
        Assert.IsTrue(result);
    }
}
