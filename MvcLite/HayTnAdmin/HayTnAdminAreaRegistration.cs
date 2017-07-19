using System.Web.Mvc;

namespace HayTnAdmin
{
    public class HayTnAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HayTnAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HayTnAdmin_default",
                "HayTnAdmin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[1] { "HayTnAdmin"}
            );
        }
    }
}