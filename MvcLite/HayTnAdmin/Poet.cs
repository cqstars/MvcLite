using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebUI.Helper;
namespace HayTnAdmin
{
   
   public class PoetController:Controller
    {
        
        [Common.Attributes.Skip]
        public ActionResult index()
        {
            return View();
        }
        [Common.Attributes.Skip]
        public ActionResult VolumeADD()
        {
            Model.Volume AddVolume = new Model.Volume();
            AddVolume.VolumeName = Request["value"].ToString();
            int ok=OperateContext.Current.BLLSession.IVolumeBLL.Add(AddVolume);

            if (ok == 1)
            {
                return Json(new { VolumeList = OperateContext.Current.BLLSession.IVolumeBLL.GetListBy_NoTrack(s => s.VolumeID > 0).ToList() }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Content("error");
            }
            
        }
        [Common.Attributes.Skip]
        /// <summary>
        /// 管理卷，列表卷
        /// </summary>
        /// <returns></returns>
        public ActionResult VolumeList()
        {
            return Json(new { VolumeList = OperateContext.Current.BLLSession.IVolumeBLL.GetListBy_NoTrack(s => s.VolumeID > 0).ToList() }, JsonRequestBehavior.AllowGet);
        }
        [Common.Attributes.Skip]
        /// <summary>
        /// 获得所有卷的总和数，以便分页显示
        /// </summary>
        /// <returns></returns>
        public ActionResult VolumeTotalPage()
        {
            return Content(OperateContext.Current.BLLSession.IVolumeBLL.GetListBy_NoTrack(s => s.VolumeID > 0).ToList().Count().ToString());
        }
        [Common.Attributes.Skip]
        
        /// <summary>
        /// 按照分页方法提供数据给页面
        /// </summary>
        /// <returns></returns>
        public ActionResult VolumeListByPage()
        {
            int pageIndex = Convert.ToInt32(Request["pageIndex"])+1;
            int pageSize = Convert.ToInt32(Request["pageSize"]);
            return Json(new { VolumeList = OperateContext.Current.BLLSession.IVolumeBLL.GetPagedList(pageIndex,pageSize,s => s.VolumeID > 0,s=>s.VolumeID).ToList()}, JsonRequestBehavior.AllowGet);
        }
        [Common.Attributes.Skip]
        /// <summary>
        /// 修改卷名
        /// </summary>
        /// <returns></returns>
        public ActionResult VolumeModify()
        {
            Model.Volume ModifyVolume = new Model.Volume();
            ModifyVolume.VolumeID = Convert.ToInt32(Request["pk"]);
            ModifyVolume.VolumeName = Request["value"].ToString();
            int ok = OperateContext.Current.BLLSession.IVolumeBLL.Modify(ModifyVolume, new string[] { "VolumeName" });
            if (ok == 1)
            {
                return Content("200");
            }
            else
            {
                return null;
            }
            
        }
    }
}
