using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int numb = 0;
        int expected = 0;

        // Act
        int actual = Fibonacci.CalculateFibonacci(numb);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int numb = 9;
        int expected = 34;

        // Act
        int actual = Fibonacci.CalculateFibonacci(numb);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}