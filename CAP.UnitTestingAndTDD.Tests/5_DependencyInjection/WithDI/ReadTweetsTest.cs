using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAP.UnitTestingAndTDD._5_DependencyInjection;
using CAP.UnitTestingAndTDD._5_DependencyInjection.WithDI;
using Moq;
using NUnit.Framework;

namespace CAP.UnitTestingAndTDD.Tests._5_DependencyInjection.WithDI
{
    [TestFixture]
    public class ReadTweetsTest
    {
        [Test]
        public void GivenTwitterApiResponse_PassesItAlong()
        {
            var apiResults = SomeTweets();
            var mockApi = new Mock<ITwitterApi>();
            mockApi.Setup(x => x.GetTweets(It.IsAny<String>()))
                .Returns(apiResults);
            var tweetReader = new TweetReader(mockApi.Object);

            var results = tweetReader.ReadTweetsForUser("asdfasdf");

            Assert.That(results, Is.Not.Null);
            Assert.That(results.Count(), Is.EqualTo(2));
            Assert.That(results.First().Contents, 
                Is.EqualTo(apiResults.First().Contents));
        }

        private IEnumerable<Tweet> SomeTweets()
        {
            return new List<Tweet>()
            {
                new Tweet("check this out too", DateTime.Now),
                new Tweet("check this out", DateTime.Now.AddDays(-1))
            };
        } 
    }
}
