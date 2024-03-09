using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = new string[0];
        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.Empty);
    }
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrang
        string[] plants = new string[]
        {
            "@--\\-"
        };
        // Act
        string result = Plants.GetFastestGrowing(plants);
        // Assert
        Assert.That(result, Is.EqualTo("Plants with 5 letters:\r\n@--\\-"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrang
        string[] plants = new string[]
        {
            "@--\\-",
            "*---",
            "____",
            "*-\\-\\"
        };
        // Act
        string result = Plants.GetFastestGrowing(plants);
        // Assert
        Assert.That(result, Is.EqualTo("Plants with 4 letters:\r\n*---\r\n____\r\n" +
            "Plants with 5 letters:\r\n@--\\-\r\n*-\\-\\"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrang
        string[] plants = new string[]
        {
            "rOse",
            "liLy",
            "AbcdE",
            "Fdgre"
        };
        // Act
        string result = Plants.GetFastestGrowing(plants);
        // Assert
        Assert.That(result, Is.EqualTo("Plants with 4 letters:\r\nrOse\r\nliLy\r\n" +
            "Plants with 5 letters:\r\nAbcdE\r\nFdgre"));
    }
}
