using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] input = new string[0];
        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.Empty);
    }


    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "Gold 8", "siLver 30" };
        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Input array fixed to have a space between the resource name and the amount.
        string[] input = new string[] { "Gold 8", "silveR 30", "copper 100", "golD 10", "silVeR 20" };

        string result = Miner.Mine(input);

        // Expected output uses Environment.NewLine for proper new line characters.
        string expected = $"gold -> 18{Environment.NewLine}silver -> 50{Environment.NewLine}copper -> 100";

        Assert.That(result, Is.EqualTo(expected));
    }
}
