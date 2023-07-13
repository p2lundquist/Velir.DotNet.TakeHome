using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakeHome.Models;

namespace TakeHome.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(true)]
        public ActionResult Index(FeedbackForm form)
        {
            if (ModelState.IsValid)
            {
                return View("ThankYou", form);
            }
            else
                ViewBag.Result = "Invalid Entries, Kindly Recheck.";
            return View();
        }

    }
}