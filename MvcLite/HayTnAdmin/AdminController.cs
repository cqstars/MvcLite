using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebUI.Helper;
namespace HayTnAdmin
{

    public class AdminController : Controller
    {
        #region 1.0 管理员登陆页面 +ActionResult Login()
        /// <summary>
        /// 1.0 管理员登陆页面
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Common.Attributes.Skip]
        public ActionResult AdminLogin()
        {
            return View();
        }
        #endregion

        #region 1.0 管理员登陆页面 +ActionResult Login()
        /// <summary>
        /// 1.0 管理员登陆页面
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Common.Attributes.Skip]
        public ActionResult AdminLogin(Model.ViewModel.LoginUser usrInfo)
        {
          
            //1.2服务器端验证，如果没有验证通过
            if (!ModelState.IsValid )
            {
                return OperateContext.Current.RedirectAjax("err", "没有权限!", null, "");
            }
            if (OperateContext.Current.LoginAdmin(usrInfo))
            {
                return OperateContext.Current.RedirectAjax("ok", "登陆成功~", null, "/HayTnAdmin/admin/index");
            }
            else
            {
                return OperateContext.Current.RedirectAjax("err", "失败~~!", null, "");
            }
        }
        #endregion

        #region 2.0 显示管理首页 +ActionResult Index()
        /// <summary>
        /// 2.0 显示管理首页
        /// </summary>
        /// <returns></returns>
        [Common.Attributes.Skip]
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region 3.0 根据当前登陆用户 权限 生成菜单 +GetMenuData()
        /// <summary>
        /// 根据当前登陆用户 权限 生成菜单
        /// </summary>
        /// <returns></returns>
        //[AjaxRequest]
        //public ActionResult GetMenuData()
        //{
        //    //MODEL.EasyUIModel.Tree tree = Helper.OperateContext.CurUserPermission;
        //    return Content(OperateContext.Current.UsrTreeJsonStr);
        //    //return Content("{\"data\":[{\"id\":1,\"text\":\"后台菜单导航\",\"state\":\"open\",\"attributes\":null,\"children\":[{\"id\":2,\"text\":\"系统管理\",\"Checked\":false}]}]}");
        //}
        #endregion
      
    }
}
