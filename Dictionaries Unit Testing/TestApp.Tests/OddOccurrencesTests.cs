using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();

        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.Empty);
    }

  
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { "the", "the" };
        // Act
         string result = OddOccurrences.FindOdd(input);
        Assert.That(result, Is.Empty);
        // Assert
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        string[] input = new string[] { "the", "the", "the" };
        
        string result = OddOccurrences.FindOdd(input);
        Assert.That(result, Is.EqualTo("the"));
        
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        string[] input = new string[] { "the", "the", "the", "that", "a", "on", "on"};

        string result = OddOccurrences.FindOdd(input);
        Assert.That(result, Is.EqualTo("the that a"));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        string[] input = new string[] { "thE", "tHe", "the", "That", "a", "on", "on" };

        string result = OddOccurrences.FindOdd(input);
        Assert.That(result, Is.EqualTo("the that a"));
    }
}
