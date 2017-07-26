 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;

namespace DALSQL
{
	public partial class DepartmentDAL : BaseDAL<Model.Department>,IDAL.IDepartmentDAL
    {
    }
	public partial class PermissionDAL : BaseDAL<Model.Permission>,IDAL.IPermissionDAL
    {
    }
	public partial class PoetDAL : BaseDAL<Model.Poet>,IDAL.IPoetDAL
    {
    }
	public partial class PoetryDAL : BaseDAL<Model.Poetry>,IDAL.IPoetryDAL
    {
    }
	public partial class RoleDAL : BaseDAL<Model.Role>,IDAL.IRoleDAL
    {
    }
	public partial class RolePermissionDAL : BaseDAL<Model.RolePermission>,IDAL.IRolePermissionDAL
    {
    }
	public partial class SubsectionDAL : BaseDAL<Model.Subsection>,IDAL.ISubsectionDAL
    {
    }
	public partial class UserDBDAL : BaseDAL<Model.UserDB>,IDAL.IUserDBDAL
    {
    }
	public partial class UserRoleDAL : BaseDAL<Model.UserRole>,IDAL.IUserRoleDAL
    {
    }
	public partial class VipUserPermissionDAL : BaseDAL<Model.VipUserPermission>,IDAL.IVipUserPermissionDAL
    {
    }
	public partial class VolumeDAL : BaseDAL<Model.Volume>,IDAL.IVolumeDAL
    {
    }
}