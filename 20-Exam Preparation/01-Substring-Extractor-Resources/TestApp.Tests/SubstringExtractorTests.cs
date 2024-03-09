using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        //Arrange
        string input = "aaa bbb ccc";
        string startMarker = "aaa";
        string endMarker = "ccc";
        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);
        //Assert
        Assert.That(result, Is.EqualTo(" bbb "));

    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "aaa bbb ccc";
        string startMarker = "dd";
        string endMarker = "ccc";
        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);
        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "aaa bbb ccc";
        string startMarker = "aaa";
        string endMarker = "dd";
        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);
        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "aaa bbb ccc";
        string startMarker = "dd";
        string endMarker = "ee";
        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);
        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "";
        string startMarker = "dd";
        string endMarker = "ccc";
        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);
        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "eedd";
        string startMarker = "ee";
        string endMarker = "ed";
        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);
        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }
}
