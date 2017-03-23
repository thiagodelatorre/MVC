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
            return View();
        }
    }
}