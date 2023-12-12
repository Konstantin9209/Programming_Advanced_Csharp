using NUnit.Framework;
using System;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        string productName = "Banana";
        double productPrice = 100;
        int productQuantity = 10;

        string expectedInventory = $"Product Inventory:{Environment.NewLine}{productName} - Price: ${productPrice:f2} - Quantity: {productQuantity}";

        this._inventory.AddProduct(productName, productPrice, productQuantity);
        string result = this._inventory.DisplayInventory();



        Assert.AreEqual(expectedInventory, result);
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        string expected = "Product Inventory:";

        string result = this._inventory.DisplayInventory();

        Assert.AreEqual (expected, result);
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        string firstProductName = "Tuna";
        double firstProductPrice = 100;
        int firstProductQuantity = 10;

        string secondProductName = "Rice";
        double secondProductPrice = 10;
        int secondProductQuantity = 5;

        string expectedOutput = $"Product Inventory:{Environment.NewLine}{firstProductName} - Price: ${firstProductPrice:f2} - Quantity: {firstProductQuantity}{Environment.NewLine}{secondProductName} - Price: ${secondProductPrice:f2} - Quantity: {secondProductQuantity}";
   this._inventory.AddProduct(firstProductName, firstProductPrice, firstProductQuantity);
        this._inventory.AddProduct(secondProductName, secondProductPrice, secondProductQuantity);

        string result = this._inventory.DisplayInventory();

        Assert.AreEqual(expectedOutput, result);
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
      double result = this._inventory.CalculateTotalValue();
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        string firstProductName = "Bread";
        double firstProductPrice = 100;
        int firstProductQuantity = 2;

        string secondProductName = "Sushi";
        double secondProductPrice = 10;
        int secondProductQuantity = 5;
        double expectedTotalSum = 250;

        this._inventory.AddProduct(firstProductName, firstProductPrice, firstProductQuantity);
        this._inventory.AddProduct(secondProductName, secondProductPrice, secondProductQuantity);

        double result = this._inventory.CalculateTotalValue();
        Assert.AreEqual(expectedTotalSum, result);
    }
}
