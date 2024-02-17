using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = new int[0];

        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1 };

        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("1 -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3 };

        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("1 -> 1\r\n2 -> 1\r\n3 -> 1"));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -1, -2, -3 };

        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("-3 -> 1\r\n-2 -> 1\r\n-1 -> 1"));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 0 };

        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("0 -> 1"));
    }
}
