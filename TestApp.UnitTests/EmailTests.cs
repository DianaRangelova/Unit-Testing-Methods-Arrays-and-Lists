using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    [Test]

    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "didika@abv.bg";

        // Act
        bool isValid = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsTrue(isValid);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string invalidEmail = "didka";

        // Act
        bool isValid = Email.IsValidEmail(invalidEmail);

        // Assert
        Assert.IsFalse(isValid);
    }

    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase("     ")]
    public void Test_IsValidEmail_NullInput(string nullEmail)
    {
        // Act
        bool isValid = Email.IsValidEmail(nullEmail);

        // Assert
        Assert.IsFalse(isValid);
    }
}
