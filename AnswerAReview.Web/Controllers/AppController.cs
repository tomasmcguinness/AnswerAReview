using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace AnswerAReview.Web.Controllers
{
    public class AppController : Controller
    {
        public ActionResult Index(long appId)
        {
            return View(appId);
        }
    }
}
