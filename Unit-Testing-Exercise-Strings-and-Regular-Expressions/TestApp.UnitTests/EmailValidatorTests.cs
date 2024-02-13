using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    
    [TestCase("ivan_ivanov@softuni.bg")]
    [TestCase("stoyan.petrov@abv.bg")]
    [TestCase("ivan+123@yahoo.bg")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    
    [TestCase("invalid mail@valid.domaim")]
    [TestCase("valid%mail@in_valid.domain")]
    [TestCase("invalid/mail@invalid.d")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
