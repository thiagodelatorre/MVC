using System.Web.Mvc;

namespace MVC.Areas.Assignment
{
    public class AssignmentAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Assignment";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Assignment_default",
                "Assignment/{controller}/{action}/{id}",
                new { area = "Assignment", controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}