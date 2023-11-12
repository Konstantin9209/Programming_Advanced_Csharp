using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
   
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";
        List<string> expected = new();

        // Act
        List<string> result =MatchUrls.ExtractUrls(text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        string text = "No valid URLs";

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        string text = "Single URL: https://softuni.bg";
        List<string> expected = new() { "https://softuni.bg" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        string text = "Multiple URL: https://www.softuni.bg, https://zpetkov.com, https://qualitysolutionslab.zpetkov.com";
        List<string> expected = new() { "https://www.softuni.bg", "https://zpetkov.com", "https://qualitysolutionslab.zpetkov.com" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        string text = "Single URL: \"https://softuni.bg/about\"";
        List<string> expected = new() { "https://softuni.bg" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        Assert.That(result, Is.EqualTo(expected));
    }
}
