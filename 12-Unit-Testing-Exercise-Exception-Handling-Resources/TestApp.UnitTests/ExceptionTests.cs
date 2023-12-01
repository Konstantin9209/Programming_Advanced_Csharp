using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "hello";
        string expected = "olleh";
        // Act
        string result = this._exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;
        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {

        decimal totalPrice = 100.0m;
        decimal discount = 10.0m;

        decimal result = this._exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        Assert.That(result, Is.EqualTo(90));
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = -100.0m;
        decimal discount = -10.0m;
        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        int[] array = new[] { 1, 2, 3 };
        int index = 1;
        int result = this._exceptions.IndexOutOfRangeGetElement(array, index);
        Assert.That(result, Is.EqualTo(2));
    }


    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = new[] { 1, 2, 3 };
        int index = -1;
        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length +2;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        bool isLoggedIn = true;

        string result = this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);

        Assert.That(result, Is.EqualTo("User logged in."));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        bool isLoggedIn = false;
        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn), Throws.InstanceOf<InvalidOperationException>());
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        string input = "3";

        int result = this._exceptions.FormatExceptionParseInt(input);
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        string input = "3.,3abc";

        Assert.That(() => this._exceptions.FormatExceptionParseInt(input),Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        Dictionary<string, int> dictionary = new()
        {
            ["first"] = 10,
            ["second"] = 15,
            ["third"] = 20
        };
        string key = "second";

        int result = this._exceptions.KeyNotFoundFindValueByKey(dictionary, key);

        Assert.That(result, Is.EqualTo(15));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        Dictionary<string, int> dictionary = new()
        {
            ["first"] = 10,
            ["second"] = 15,
            ["third"] = 20
        };
        string key = "fourth";

        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(dictionary, key),Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        int num1 = 2;
        int num2 = 3;

        int result = this._exceptions.OverflowAddNumbers(num1, num2);

        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
       
        
        int num1 = int.MaxValue;
        int num2 = 3;

        Assert.That(() => this._exceptions.OverflowAddNumbers(num2, num1), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {

        int num1 = int.MinValue;
        int num2 = -1;

        Assert.That(() => this._exceptions.OverflowAddNumbers(num2, num1), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // TODO: finish test
    }
}
