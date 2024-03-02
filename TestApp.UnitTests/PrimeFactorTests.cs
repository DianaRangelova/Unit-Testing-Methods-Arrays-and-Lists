using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long primeNumb = 7;
        long expected = 7;

        // Act
        long actual = PrimeFactor.FindLargestPrimeFactor(primeNumb);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long nonPrimeNumb = 100;
        long expected = 5;

        // Act
        long actual = PrimeFactor.FindLargestPrimeFactor(nonPrimeNumb);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
