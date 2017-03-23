using Service.Bulletin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class BaseController : Controller
    {
        // protecting field for usage on derived controllers
        protected readonly IBulletinService _bulletinService;

        public BaseController()
        {
            _bulletinService = new BulletinService();
        }
    }
}