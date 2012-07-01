using System.Collections.Generic;
using System.Linq;

namespace ReadShareThumbsUpService.Provider
{
    public class InMemFeedProvider : IFeedProvider
    {
        private Dictionary<string, List<string>> FeedUrlLists { get; set; }

        public InMemFeedProvider()
        {
            FeedUrlLists = new Dictionary<string, List<string>>();
        }

        public void AddFeed(string userName, string feedUrl)
        {
            List<string> userFeedUrls;
            if (!FeedUrlLists.TryGetValue(userName, out userFeedUrls))
            {
                userFeedUrls = new List<string>();
                FeedUrlLists.Add(userName, userFeedUrls);
            }

            if (!userFeedUrls.Contains(feedUrl))
                userFeedUrls.Add(feedUrl);
        }

        public IEnumerable<string> GetFeeds(string userName)
        {
            List<string> userFeedUrls;
            if (!FeedUrlLists.TryGetValue(userName, out userFeedUrls))
            {
                return Enumerable.Empty<string>();
            }

            return new List<string>(userFeedUrls);
        }

    }
}