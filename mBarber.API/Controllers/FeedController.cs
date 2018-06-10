using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mBarber.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/feed")]
    public class FeedController : Controller
    {
        #region GetFeeds
        [Route("getfeeds")]
        [HttpGet]
        public string GetFeeds()
        {
            return "GetFeeds";
        }
        #endregion

        #region See Feeds
        [Route("seefeeds")]
        [HttpPost]
        public object SeeFeeds()
        {
            return null;
        }
        #endregion

        #region Post Feeds
        [Route("postfeeds")]
        [HttpPost]
        public object PostFeeds()
        {
            return null;
        }
        #endregion

    }
}