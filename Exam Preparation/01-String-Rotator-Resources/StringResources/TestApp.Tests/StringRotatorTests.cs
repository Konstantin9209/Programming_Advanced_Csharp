using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
     string input = string.Empty;
        string result = StringRotator.RotateRight(input, 99);
        Assert.AreEqual(input, result);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        string input = "Hello!";
        int positions = 0;
        string result = StringRotator.RotateRight(input, positions);
        Assert.AreEqual(input, result);
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        string input = "Hello!";
        string expected = "o!Hell";
        int positions = 2;

        string result = StringRotator.RotateRight(input, positions);
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        string input = "Hello!";
        string expected = "o!Hell";
        int positions = -2;

        string result = StringRotator.RotateRight(input, positions);
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        string input = "Hello!";
        string expected = "o!Hell";
        int positions = 2 + (input.Length * 2);

        string result = StringRotator.RotateRight(input, positions);
        Assert.AreEqual(expected, result);
    }
}
