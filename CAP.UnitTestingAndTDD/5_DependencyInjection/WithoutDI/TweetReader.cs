using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP.UnitTestingAndTDD._5_DependencyInjection.WithoutDI
{
    public class TweetReader
    {
        public IEnumerable<Tweet> ReadTweetsForUser(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException(userName);
            }

            var api = new TwitterApi();

            return api.GetTweets(userName);
        } 
    }
}
