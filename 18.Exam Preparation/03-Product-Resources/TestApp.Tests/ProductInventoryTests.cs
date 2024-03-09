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
        //Arrange
        string productName = "Banana";
        double productPrice = 100;
        int productQuantity = 10;

        string expectedInventory = $"Product Inventory:{Environment.NewLine}" +
            $"{productName} - Price: ${productPrice:f2} - Quantity:" +
            $" {productQuantity}";

        //Act
        this._inventory.AddProduct(productName, productPrice, productQuantity);

        string result = this._inventory.DisplayInventory(); 

        //Assert
        Assert.AreEqual(expectedInventory, result);
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        //Arrange
        string expected = "Product Inventory:";
        //Act
        string result = this._inventory.DisplayInventory();
        //Assert
        Assert.AreEqual (expected, result);

    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        //Arrange
        string firstProductName = "Tuna";
        double firstProductPrice = 100;
        int firstProductQuantity = 10;
        string SecondProductName = "Rice";
        double SecondProductPrice = 100;
        int SecondProductQuantity = 10;

        string expectedInventory = $"Product Inventory:{Environment.NewLine}" +
            $"{firstProductName} - Price: ${firstProductPrice:f2} - Quantity:" +
            $" {firstProductQuantity}{Environment.NewLine}{SecondProductName} - Price: ${SecondProductPrice:f2} - Quantity:" +
            $" {SecondProductQuantity}";

        //Act
        this._inventory.AddProduct(firstProductName, firstProductPrice, firstProductQuantity);
        this._inventory.AddProduct(SecondProductName, SecondProductPrice, SecondProductQuantity);

        string result = this._inventory.DisplayInventory();

        //Assert
        Assert.AreEqual(expectedInventory, result);
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        //Arrange
        //Act
        double result = this._inventory.CalculateTotalValue();
        //Assert
        Assert.That(result, Is.Zero);
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        //Arrange
        string firstProductName = "Bread";
        double firstProductPrice = 100;
        int firstProductQuantity = 2;
        string SecondProductName = "Sushi";
        double SecondProductPrice = 10;
        int SecondProductQuantity = 5;

        int expectedSum = 250;

        //Act
        this._inventory.AddProduct(firstProductName, firstProductPrice, firstProductQuantity);
        this._inventory.AddProduct(SecondProductName, SecondProductPrice, SecondProductQuantity);

        double result = this._inventory.CalculateTotalValue();

        //Assert
        Assert.AreEqual(expectedSum, result);
    }
}
