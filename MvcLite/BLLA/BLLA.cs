 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLLA
{
	public partial class Department : BaseBLL<Model.Department>,IBLL.IDepartmentBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IDepartmentDAL;
		}
    }
	public partial class Permission : BaseBLL<Model.Permission>,IBLL.IPermissionBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IPermissionDAL;
		}
    }
	public partial class Role : BaseBLL<Model.Role>,IBLL.IRoleBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IRoleDAL;
		}
    }
	public partial class RolePermission : BaseBLL<Model.RolePermission>,IBLL.IRolePermissionBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IRolePermissionDAL;
		}
    }
	public partial class UserDB : BaseBLL<Model.UserDB>,IBLL.IUserDBBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IUserDBDAL;
		}
    }
	public partial class UserRole : BaseBLL<Model.UserRole>,IBLL.IUserRoleBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IUserRoleDAL;
		}
    }
	public partial class VipUserPermission : BaseBLL<Model.VipUserPermission>,IBLL.IVipUserPermissionBLL
    {
		public override void SetDAL()
		{
			idal = DBSession.IVipUserPermissionDAL;
		}
    }
}