using NUnit.Framework;
using TestApp;

namespace TestApp.Tests
{
    [TestFixture]
    public class SubstringExtractorTests
    {
        [Test]
        public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
        {
            string input = "Good [Morning]!";
            string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, "[", "]");
            Assert.AreEqual("Morning", result);
        }

        [Test]
        public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
        {
            string input = "Good Morning!";
            string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, "[", "]");
            Assert.AreEqual("Substring not found", result);
        }

        [Test]
        public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
        {
            string input = "Good [Morning!";
            string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, "[", "]");
            Assert.AreEqual("Substring not found", result);
        }

        [Test]
        public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
        {
            string input = "Good Morning!";
            string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, "{", "}");
            Assert.AreEqual("Substring not found", result);
        }

        [Test]
        public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
        {
            string input = "";
            string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, "[", "]");
            Assert.AreEqual("Substring not found", result);
        }

        [Test]
        public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
        {
            string input = "Good ][ Morning!";
            string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, "[", "]");
            Assert.AreEqual("Substring not found", result);
        }
    }
}
