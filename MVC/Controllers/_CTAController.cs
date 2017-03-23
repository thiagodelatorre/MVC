using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    // Use for centralization of Call-to-actions
    public class _CTAController : BaseController
    {

        [ChildActionOnly] // Ensure this is used only inside of other Actions
        public ActionResult _CTA()
        {
            // TODO: move this code to its own service (similarly to Service.Bulletin)
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
    }
}