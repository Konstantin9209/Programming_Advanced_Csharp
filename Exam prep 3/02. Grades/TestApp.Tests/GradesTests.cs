using NUnit.Framework;
using System.Collections.Generic;
using TestApp;
using System;

namespace TestApp.Tests
{
    [TestFixture]
    public class GradesTests
    {
        [Test]
        public void Test_GetBestStudents_ReturnsBestThreeStudents()
        {
            var grades = new Dictionary<string, int>
            {
                { "Alice", 90 },
                { "Bob", 85 },
                { "Charlie", 95 },
                { "Dave", 80 },
                { "Eve", 70 }
            };
            string result = Grades.GetBestStudents(grades);
            string expected = $"Charlie with average grade 95.00{Environment.NewLine}Alice with average grade 90.00{Environment.NewLine}Bob with average grade 85.00";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
        {
            var grades = new Dictionary<string, int>();
            string result = Grades.GetBestStudents(grades);
            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
        {
            var grades = new Dictionary<string, int>
            {
                { "Alice", 90 },
                { "Bob", 85 }
            };
            string result = Grades.GetBestStudents(grades);
            string expected = $"Alice with average grade 90.00{Environment.NewLine}Bob with average grade 85.00";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
        {
            var grades = new Dictionary<string, int>
            {
                { "Charlie", 90 },
                { "Bob", 90 },
                { "Alice", 90 }
            };
            string result = Grades.GetBestStudents(grades);
            string expected = $"Alice with average grade 90.00{Environment.NewLine}Bob with average grade 90.00{Environment.NewLine}Charlie with average grade 90.00";
            Assert.AreEqual(expected, result);
        }
    }
}
