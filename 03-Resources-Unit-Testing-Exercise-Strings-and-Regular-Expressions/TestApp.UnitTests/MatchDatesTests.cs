using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string dates = "31-Dec-2022 random text";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        string result = MatchDates.Match(dates);       
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string dates = "Invalid date format";
        string expected = string.Empty;
        string result = MatchDates.Match(dates);
        // Assert
        Assert.That(result, Is.EqualTo(expected));

        // Act

        // Assert
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        string dates = "12.Jan.2001 31-Dec-2022 random text";
        string expected = "Day: 12, Month: Jan, Year: 2001";

        // Act
        string result = MatchDates.Match(dates);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        string dates = "";
        string expected = string.Empty;
        string result = MatchDates.Match(dates);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        string? dates = null;
       
        // Assert
        Assert.That(()=> MatchDates.Match(dates), Throws.ArgumentException);
    }
}
