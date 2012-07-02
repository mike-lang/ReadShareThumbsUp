using System;
using System.Web;
using System.Web.Mvc;
using Ninject;
using ReadShareThumbsUpService.Provider;
using SyncService.Misc;

namespace ReadShareThumbsUpService.Controllers
{
    public class FeedController : Controller
    {
        [Inject]
        public IFeedProvider FeedProvider { get; set; }

        [JsonpFilter]
        public ActionResult AddFeed(string userName, string feedUrl)
        {
            FeedProvider.AddFeed(userName, feedUrl);
            return Json(new {response = "OK"}, JsonRequestBehavior.AllowGet);
        }

        [JsonpFilter]
        public ActionResult GetFeeds(string userName)
        {
            var feeds = FeedProvider.GetFeeds(userName);
            return Json(feeds, JsonRequestBehavior.AllowGet);
        }
    }
}
