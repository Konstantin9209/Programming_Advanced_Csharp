using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{

    [TestCase("ivan@abv.bg")]
    [TestCase("petko@abv.bg")]
    [TestCase("azsym@abv.bg")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

   
    [TestCase("invalid email@abv.bg")]
    [TestCase("validemail@abv_avb.bg")]
    [TestCase("invalid/email@abv.bg")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
