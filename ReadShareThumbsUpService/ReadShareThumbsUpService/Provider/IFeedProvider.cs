using System.Collections.Generic;

namespace ReadShareThumbsUpService.Provider
{
    public interface IFeedProvider
    {
        void AddFeed(string userName, string feedUrl);
        IEnumerable<string> GetFeeds(string userName);
    }
}