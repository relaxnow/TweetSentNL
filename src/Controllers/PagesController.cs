using System;
using System.Collections.Generic;
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
            String _consumerKey         = "";
            String _consumerSecret      = "";
            String _accessToken         = "";
            String _accessTokenSecret   = ""; 

            // In v1.1, all API calls require authentication
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith( _accessToken, _accessTokenSecret);

//            var result = service.Search(
//                new SearchOptions{ 
//                    Q = "Delta", 
//                    Lang = "nl", 
//                    Count = 50
//                }
//            );
            //ViewBag.Tweets = result.Statuses;
            return View();
        }
    }
}