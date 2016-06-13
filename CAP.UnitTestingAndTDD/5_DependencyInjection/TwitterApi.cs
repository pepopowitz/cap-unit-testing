using System;
using System.Collections.Generic;
using System.Linq;

namespace CAP.UnitTestingAndTDD._5_DependencyInjection
{
    public class TwitterApi : ITwitterApi
    {
        public IEnumerable<Tweet> GetTweets(string userName)
        {
            throw new NotImplementedException("This exception means you've tried to call out to Twitter!");
        }
    }
}