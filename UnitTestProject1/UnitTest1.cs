using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication7;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class CrawlerTest
    {

        private Crawler crawler;

        [SetUp]
        public void Init()
        {
            crawler = new Crawler();
        }

        [TestCase]
        public void TestCrawl()
        {
            var result =
                crawler.DirSearch(@"C:\Users\whitehawk\Documents\Visual Studio 2015\Projects\ConsoleApplication7",
                    @"index.html", @"Hello there!");

            Assert.IsInstanceOf(typeof(List<string>), result);
        }

        [TearDown]
        public void Dispose()
        {
            crawler = null;
        }
    }
}