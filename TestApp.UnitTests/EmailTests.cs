using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    [Test]

    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string email = "didika@abv.bg";

        // Act
        bool result = Email.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string invalidEmail = "didka";

        // Act
        bool result = Email.IsValidEmail(invalidEmail);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase("     ")]
    public void Test_IsValidEmail_NullInput(string email)
    {
        // Act
        bool result = Email.IsValidEmail(email);

        // Assert
        Assert.IsFalse(result);
    }
}
