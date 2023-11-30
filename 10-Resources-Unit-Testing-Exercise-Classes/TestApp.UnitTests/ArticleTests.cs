﻿using NUnit.Framework;
using System;

namespace TestApp.UnitTests
{
    public class ArticleTests
    {
        private Article _article;

        [SetUp]
        public void SetUp()
        {
            this._article = new Article();
        }

        [Test]
        public void Test_AddArticles_ReturnsArticleWithCorrectData()
        {
            // Arrange
            string[] articleData =
            {
                "Article1 Content1 Author1",
                "Article2 Content2 Author2",
                "Article3 Content3 Author3",
            };

            // Act
            Article result = this._article.AddArticles(articleData);

            // Assert
            Assert.That(result.ArticleList, Has.Count.EqualTo(3));
            Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article1"));
            Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
            Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
        }

        [Test]
        public void Test_GetArticleList_SortsArticlesByTitle()
        {
            // Arrange
            Article inputArticle = new Article()
            {
                ArticleList = new System.Collections.Generic.List<Article>()
                {
                    new Article()
                    {
                        Author = "Teodor",
                        Content = "Some Content",
                        Title = "Begginers Coding"
                    },
                    new Article()
                    {
                        Author = "Ivan",
                        Content = "Other Content",
                        Title = "A brief overview of Architecture"
                    }
                }
            };

            string expected = $"A brief overview of Architecture - Other Content: Ivan{Environment.NewLine}Begginers Coding - Some Content: Teodor";

            // Act
            string actual = this._article.GetArticleList(inputArticle, "title");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
        {
            // Arrange
            Article inputArticle = new Article()
            {
                ArticleList = new System.Collections.Generic.List<Article>()
            };

            string expected = "";

            // Act
            string actual = this._article.GetArticleList(inputArticle, "invalidCriteria");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
