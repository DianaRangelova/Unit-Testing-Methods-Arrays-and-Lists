using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] inputDigits = { 'd', 'i', 'd', 'i', '1', '2', '3' };
        char[] expected = { 'd', 'i', 'd', 'i' };

        // Act
        char[] result = Fake.RemoveStringNumbers(inputDigits);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] inputDigits = { ' ' };
        char[] expected = { ' ' };

        // Act
        char[] result = Fake.RemoveStringNumbers(inputDigits);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = Array.Empty<char>();

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
