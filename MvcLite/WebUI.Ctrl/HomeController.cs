using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebUI.Helper;
namespace WebUI.Ctrl
{
    public class HomeController:Controller
    {
        public ActionResult Index() {
           var user= OperateContext.Current.BLLSession.IUserDBBLL.GetListBy(u => u.UserID > 0).ToList();
            ViewData["user"]= user;
            return View();
        }

        public ActionResult UserLogin()
        {
            return View();
        }
    }
}
