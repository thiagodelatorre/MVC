using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult _CTA()
        {
            Random r = new Random();
            double chance = r.NextDouble();

            string message = "";

            if(chance < 0.33)
            {
                message = "Back-end can apply complex rules to choose the best CTA.";
            }
            else if(chance < 0.66)
            {
                message = "Can be used for some simple A-B tests and statistics.";
            } else
            {
                message = "May retrieve CTA content from other systems.";
            }

            ViewBag.message = message;

            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult _Bulletin()
        {
            List<BulletPoint> bulletin = new List<BulletPoint>
            {
                new BulletPoint { Id=0, Point="Bullet Point one" },
                new BulletPoint { Id=1, Point="Bullet Point two" },
                new BulletPoint { Id=2, Point="Bullet Point three" },
            };

            return PartialView(bulletin);
        }
    }
}