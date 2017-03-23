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
            // Please observe how the area is being accepted as empty. This emplies that the empty route uses the "Assignment_default", don't use it on other Areas
            context.MapRoute(
                "Assignment_default",
                "{area}/{controller}/{action}/{id}",
                new { area = "Assignment", controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}