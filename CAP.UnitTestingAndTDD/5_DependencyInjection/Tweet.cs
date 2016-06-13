using System;

namespace CAP.UnitTestingAndTDD._5_DependencyInjection
{
    public class Tweet
    {
        public Tweet()
        {
            
        }

        public Tweet(string contents, DateTime datePosted)
        {
            this.Contents = contents;
            this.DatePosted = datePosted;
        }

        public string Contents { get; set; }
        public DateTime DatePosted { get; set; }
    }
}