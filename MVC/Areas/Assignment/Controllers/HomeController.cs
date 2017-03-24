using MVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Assignment.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Assignment/Home
        public ActionResult Index()
        {
            // using View full name because of http://stackoverflow.com/questions/2140208/how-to-set-a-default-route-to-an-area-in-mvc
            return View("~/Areas/Assignment/Views/Home/Index.cshtml");
        }

        //public ActionResult Exception()
        //{
        //    throw new System.Exception("Unexpected error");
        //}
    }
}