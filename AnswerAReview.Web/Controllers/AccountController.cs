using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace AnswerAReview.Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index(long appId)
        {
            return View();
        }
    }
}
