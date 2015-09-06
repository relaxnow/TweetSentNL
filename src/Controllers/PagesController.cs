using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TweetSharp;

namespace TweetSentNL.Controllers
{
    public class PagesController : Controller
    {
        /// <summary>
        /// Homepage
        /// </summary>
        public ActionResult Overview()
        {
            // Set up your credentials
            String _consumerKey         = ConfigurationManager.ConnectionStrings["TWITTER_CONSUMER_KEY"].ConnectionString;
            String _consumerSecret      = ConfigurationManager.ConnectionStrings["TWITTER_CONSUMER_SECRET"].ConnectionString;
            String _accessToken         = ConfigurationManager.ConnectionStrings["TWITTER_ACCESS_TOKEN"].ConnectionString;
            String _accessTokenSecret   = ConfigurationManager.ConnectionStrings["TWITTER_ACCESS_TOKEN_SECRET"].ConnectionString;

            // In v1.1, all API calls require authentication
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith( _accessToken, _accessTokenSecret);

            var result = service.Search(
                new SearchOptions{ 
                    Q = "rtlz", 
                    Lang = "nl", 
                    Count = 50
                }
            );
            ViewBag.Tweets = result.Statuses;
            return View();
        }
    }
}