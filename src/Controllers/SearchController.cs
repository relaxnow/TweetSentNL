using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TweetSharp;

namespace TweetSentNL.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Start()
        {
            return View();
        }

        public ActionResult Results(string Q) 
        {
            // Set up your credentials
            String _consumerKey         = ConfigurationManager.ConnectionStrings["TWITTER_CONSUMER_KEY"].ConnectionString;
            String _consumerSecret      = ConfigurationManager.ConnectionStrings["TWITTER_CONSUMER_SECRET"].ConnectionString;
            String _accessToken         = ConfigurationManager.ConnectionStrings["TWITTER_ACCESS_TOKEN"].ConnectionString;
            String _accessTokenSecret   = ConfigurationManager.ConnectionStrings["TWITTER_ACCESS_TOKEN_SECRET"].ConnectionString;

            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith( _accessToken, _accessTokenSecret);

            var result = service.Search(
                new SearchOptions{ 
                    Q = Q, 
                    Lang = "nl", 
                    Count = 50
                }
            );

            ViewBag.Tweets = result.Statuses;
            return View();
        }
    }
}