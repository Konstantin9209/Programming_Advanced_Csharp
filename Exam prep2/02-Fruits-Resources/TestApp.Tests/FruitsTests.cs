using System.Collections.Generic;
using System.Security;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            ["lemon"] = 10,
            ["orange"] = 20
        };
        string currentFruit = "lemon";

        int result = Fruits.GetFruitQuantity(fruits, currentFruit);
        
        Assert.That(result, Is.EqualTo(10));
        
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            ["lemon"] = 10,
            ["orange"] = 20
        };
        string currentFruit = "kiwi";

        int result = Fruits.GetFruitQuantity(fruits, currentFruit);

        Assert.That(result, Is.EqualTo(0));

    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        Dictionary<string, int> fruits = new Dictionary<string, int>();
      
        string currentFruit = "lemon";

        int result = Fruits.GetFruitQuantity(fruits, currentFruit);

        Assert.That(result, Is.EqualTo(0));

    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        Dictionary<string, int> fruits = null;
   
        string currentFruit = "kiwi";

        int result = Fruits.GetFruitQuantity(fruits, currentFruit);

        Assert.That(result, Is.EqualTo(0));

    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            ["lemon"] = 10,
            ["orange"] = 20
        };
        string currentFruit = null;

        int result = Fruits.GetFruitQuantity(fruits, currentFruit);

        Assert.That(result, Is.EqualTo(0));

    }
}
