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
        List<string> input = new() { "a" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("a -> 1"));
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
    [Test]
    public void Test_Count_WithUpperCaseAndNumberCharacters_ShouldReturnCountString()
    {
        List<string> input = new() { "aa!a", "!aabbccc", "ababcba", "ABC123", "CBA231", "BCA321" };

        StringBuilder sb = new();
        sb.AppendLine("a -> 8");
        sb.AppendLine("! -> 2");
        sb.AppendLine("b -> 5");
        sb.AppendLine("c -> 4");
        sb.AppendLine("A -> 3");
        sb.AppendLine("B -> 3");
        sb.AppendLine("C -> 3");
        sb.AppendLine("1 -> 3");
        sb.AppendLine("2 -> 3");
        sb.AppendLine("3 -> 3");
      
        string expected = sb.ToString().Trim();


        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
