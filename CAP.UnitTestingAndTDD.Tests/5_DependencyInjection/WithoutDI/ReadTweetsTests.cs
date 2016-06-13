using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAP.UnitTestingAndTDD._5_DependencyInjection.WithoutDI;
using NUnit.Framework;

namespace CAP.UnitTestingAndTDD.Tests._5_DependencyInjection.WithoutDI
{
    [TestFixture]
    public class ReadTweetsTests
    {
        [Test]
        public void GivenTwitterApiResponse_PassesItAlong()
        {
            var tweetReader = new TweetReader();

            //This is not a unit test!
            //There is no way I can call this method
            // without it actually calling out to Twitter.
            var results = tweetReader.ReadTweetsForUser("asdfsdf");

            Assert.That(results, Is.Not.Null);
            //Because it is not a unit test, 
            // this assertion especially would be very fragile.
            // As soon as the user made a new tweet, this test would have to be updated!
            Assert.That(results.Count(), Is.EqualTo(2));
        }
    }
}
