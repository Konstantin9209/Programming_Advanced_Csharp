using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
string[] input =Array.Empty<string>();
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(result, Is.Empty);
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] input = new[] { "alabala" };
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(result, Is.EqualTo("alabala"));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        string[] input = new[] { "alabala", "ala", "bala" };
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(result, Is.EqualTo("balaalaalabala"));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        string[] input = null;
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        string[] input = new[] { "   ", "  ", " " };
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(result, Is.EqualTo("      "));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        string[] input = new[] { "alabala", "ala", "bala", "alabala", "ala", "bala", "alabala", "ala", "bala", "alabala", "ala", "bala"};
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(result, Is.EqualTo("balaalaalabalabalaalaalabalabalaalaalabalabalaalaalabala"));
    }
}
