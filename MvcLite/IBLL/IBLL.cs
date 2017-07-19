 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace IBLL
{
	public partial interface IDepartmentBLL : IBaseBLL<Model.Department>
    {
    }

	public partial interface IPermissionBLL : IBaseBLL<Model.Permission>
    {
    }

	public partial interface IRoleBLL : IBaseBLL<Model.Role>
    {
    }

	public partial interface IRolePermissionBLL : IBaseBLL<Model.RolePermission>
    {
    }

	public partial interface IUserDBBLL : IBaseBLL<Model.UserDB>
    {
    }

	public partial interface IUserRoleBLL : IBaseBLL<Model.UserRole>
    {
    }

	public partial interface IVipUserPermissionBLL : IBaseBLL<Model.VipUserPermission>
    {
    }


}