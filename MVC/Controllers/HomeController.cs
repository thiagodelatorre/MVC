using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : BaseController
    {

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

        [OutputCache(Duration = 3600)]
        [ChildActionOnly]
        public ActionResult _Bulletin()
        {
            List<BulletPoint> bulletin = new List<BulletPoint>
            {
                new BulletPoint { Id=0, Point="Overall: Solution created from Empty template to guaranteed that only used code is maintained." },
                new BulletPoint { Id=1, Point="Overall: Front-end kept minimal to meet the requirements." },
                new BulletPoint { Id=2, Point="Overall: Applied maintainability concepts to back-end (production-ready code)." },
                new BulletPoint { Id=3, Point="CTA: Generates from an action allowing dynamic content based on profile and statistics gathering." },
                new BulletPoint { Id=4, Point="CTA: Link for CTA button could be a redirected from an action to record the successful user's interaction" },
                new BulletPoint { Id=5, Point="Bullet Point List: Annotation used on model (DisplayName)" },
                new BulletPoint { Id=6, Point="Bullet Point List: Generates from Action as a reusable component" },
                new BulletPoint { Id=7, Point="Bullet Point List: Uses DisplayTemplates to make it even more reusable" },
                new BulletPoint { Id=7, Point="Bullet Point List: Uses OutputCache (refreshing every 3600s) as this component just change" },
            };

            return PartialView(bulletin);
        }
    }
}