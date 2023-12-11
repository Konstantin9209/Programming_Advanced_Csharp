using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> firstDictonary = new Dictionary<string, int>();
        Dictionary<string, int> secondDictonary = new();

        Dictionary<string , int> result = DictionaryIntersection.Intersect(firstDictonary, secondDictonary);
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> firstDictonary = new()
        {
            { "one", 1 },
            { "two", 2 },
        };
        Dictionary<string, int> secondDictonary = new();

        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictonary, secondDictonary);
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> firstDictonary = new()
        {
            { "one", 1 },
            { "two", 2 },
        };
        Dictionary<string, int> secondDictonary = new()
                    {
            { "three", 3 },
            { "four", 4 },
        };

        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictonary, secondDictonary);
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        Dictionary<string, int> firstDictonary = new()
        {
            { "one", 1 },
            { "two", 2 },
        };
        Dictionary<string, int> secondDictonary = new()
                    {
            { "one", 1 },
            { "four", 4 },
        };

        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictonary, secondDictonary);
        Assert.AreEqual(1, result.Count);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> firstDictonary = new()
        {
            { "one", 1 },
            { "two", 2 },
        };
        Dictionary<string, int> secondDictonary = new()
                    {
            { "one", 10 },
            { "two", 20 },
        };

        Dictionary<string, int> result = DictionaryIntersection.Intersect(firstDictonary, secondDictonary);
        Assert.AreEqual(0, result.Count);
    }
}
