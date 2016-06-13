using System.Collections.Generic;
using System.Linq;

namespace CAP.UnitTestingAndTDD._5_DependencyInjection
{
    public class TwitterApi : ITwitterApi
    {
        public IEnumerable<Tweet> GetTweets(string userName)
        {
            //Pretend that this calls out to the twitter api
            return Enumerable.Empty<Tweet>();
        }
    }
}