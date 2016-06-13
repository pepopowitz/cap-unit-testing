using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP.UnitTestingAndTDD._5_DependencyInjection.WithDI
{
    public class TweetReader
    {
        public TweetReader(ITwitterApi twitterApi)
        {
            _twitterApi = twitterApi;
        }

        private ITwitterApi _twitterApi;

        public IEnumerable<Tweet> ReadTweetsForUser(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException(userName);
            }

            return _twitterApi.GetTweets(userName);
        }
    }
}
