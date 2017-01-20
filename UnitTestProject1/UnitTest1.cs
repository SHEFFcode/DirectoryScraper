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
        [TestCase]
        public void TestCrawl()
        {
            Crawler crawler = new Crawler();
            var result =
                crawler.DirSearch(@"C:\Users\whitehawk\Documents\Visual Studio 2015\Projects\ConsoleApplication7",
                    @"index.html", @"Hello there!");

            Assert.IsInstanceOf(typeof(List<string>), result);
        }
    }
}