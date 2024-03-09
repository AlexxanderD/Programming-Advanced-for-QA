using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        //arrange
        string input = string.Empty;

        //act
        string result = StringRotator.RotateRight(input, 99);


        //assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        //arrange
        string input = "Hello!";
        int positions = 0;

        //act
        string result = StringRotator.RotateRight(input, positions);


        //assert
        Assert.AreEqual(input , result);
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        //arrange
        string input = "Hello!";
        string expexted = "o!Hell";
        int positions = 2;
        
        //act
        string result = StringRotator.RotateRight(input, positions);


        //assert
        Assert.AreEqual(expexted, result);
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        //arrange
        string input = "Hello!";
        string expexted = "o!Hell";
        int positions = -2;

        //act
        string result = StringRotator.RotateRight(input, positions);


        //assert
        Assert.AreEqual(expexted, result);
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        //arrange
        string input = "Hello!";
        string expexted = "o!Hell";
        int positions = 2 + input.Length;

        //act
        string result = StringRotator.RotateRight(input, positions);


        //assert
        Assert.AreEqual(expexted, result);
    }
}
