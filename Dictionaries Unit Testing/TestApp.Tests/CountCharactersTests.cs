using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        List<string> input = new() { "", "", "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        List<string> input = new() { "aaa", "aa", "a" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("a -> 6"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        List<string> input = new() { "aaa", "aabbccc", "ababcba" };

        StringBuilder sb = new();
        sb.AppendLine("a -> 8");
        sb.AppendLine("b -> 5");
        sb.AppendLine("c -> 4");
        string expected = sb.ToString().Trim();


        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        List<string> input = new() { "aaa!", "aab!bccc", "ababc!ba" };

        StringBuilder sb = new();
        sb.AppendLine("a -> 8");
        sb.AppendLine("! -> 3");
        sb.AppendLine("b -> 5");
        sb.AppendLine("c -> 4");
        string expected = sb.ToString().Trim();


        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
