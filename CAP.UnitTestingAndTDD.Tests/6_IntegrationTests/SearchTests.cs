using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAP.UnitTestingAndTDD._6_IntegrationTests;
using CAP.UnitTestingAndTDD._6_IntegrationTests.Api;
using NUnit.Framework;

namespace CAP.UnitTestingAndTDD.Tests._6_IntegrationTests
{
    [TestFixture]
    public class SearchTests
    {
        private FlickrReader _reader;

        [SetUp]
        public void TestSetup()
        {
            _reader = new FlickrReader(
                new FlickrClient(),
                new FlickrPhotoMapper());
        }

        [Test]
        public void ReturnsResultsForMountainBiking()
        {
            var result = _reader.SearchFlickr("mountain biking moab");

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(10));
            Assert.That(result.First().Url, Is.EqualTo("https://farm5.staticflickr.com/4573/38625822721_1cc0d16f7b.jpg"));
            Assert.That(result.First().Title, Is.EqualTo("Adem in Moab, Utah"));
        }
    }
}
