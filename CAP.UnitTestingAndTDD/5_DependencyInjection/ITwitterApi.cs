using System.Collections.Generic;

namespace CAP.UnitTestingAndTDD._5_DependencyInjection
{
    public interface ITwitterApi
    {
        IEnumerable<Tweet> GetTweets(string userName);
    }
}