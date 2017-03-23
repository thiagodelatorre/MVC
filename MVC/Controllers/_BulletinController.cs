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
        [OutputCache(Duration = 3600)]
        [ChildActionOnly]
        public ActionResult _Bulletin()
        {
            return PartialView(_bulletinService.getBulletPoints());
        }
    }
}