using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentFeedback.Models;

namespace StudentFeedback.Controllers
{
    public class FeedbackController : Controller
    {

        static List<Feedback> feedbackList = new List<Feedback>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(feedbackList);
        }
        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            feedbackList.Add(feedback);
            return RedirectToAction("List");
        }
    }
}