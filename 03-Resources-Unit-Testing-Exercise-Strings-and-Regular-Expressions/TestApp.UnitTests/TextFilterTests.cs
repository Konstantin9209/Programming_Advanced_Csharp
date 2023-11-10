using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "I love to make love";
        string[] banned = new string[] { "bear" };
        // Act
        string result = TextFilter.Filter(banned, text);
        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        string text = "I love to make love";
        string[] banned = new string[] { "love" };
        string expected = "I **** to make ****";
        // Act
        string result = TextFilter.Filter(banned, text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "I love to make love";
        string[] banned = Array.Empty<string>();
        // Act
        string result = TextFilter.Filter(banned, text);
        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        string text = "I love to make love";
        string[] banned = new string[] { "love to", "make" };
        string expected = "I ******* **** love";
        // Act
        string result = TextFilter.Filter(banned, text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
