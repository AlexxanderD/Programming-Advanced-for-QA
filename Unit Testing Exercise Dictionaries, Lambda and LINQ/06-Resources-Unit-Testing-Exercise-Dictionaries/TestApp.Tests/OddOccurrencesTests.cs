using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }


    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { "the", "the" };
       // Act
       string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = new string[] { "the", "the", "the" };
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("the"));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = new string[] { "the", "the", "the", "that", "a", "a", "a", "on", "on" };
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("the that a"));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "tHe", "tHe", "the", "that", "A", "a", "a", "On", "on" };
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("the that a"));
    }
}
