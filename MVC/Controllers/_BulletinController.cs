using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    // Central component for displaying bulletin information
    public class _BulletinController : BaseController
    {
        [OutputCache(Duration = 3600)] // Reuses the same view for 1h
        [ChildActionOnly] // Ensure this is used only inside of other Actions
        public ActionResult _Bulletin()
        {
            return PartialView(_bulletinService.getBulletPoints());
        }
    }
}