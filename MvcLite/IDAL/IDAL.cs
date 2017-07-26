
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
namespace IDAL
{
	public partial interface IDepartmentDAL : IBaseDAL<Model.Department>
    {
    }

	public partial interface IPermissionDAL : IBaseDAL<Model.Permission>
    {
    }

	public partial interface IPoetDAL : IBaseDAL<Model.Poet>
    {
    }

	public partial interface IPoetryDAL : IBaseDAL<Model.Poetry>
    {
    }

	public partial interface IRoleDAL : IBaseDAL<Model.Role>
    {
    }

	public partial interface IRolePermissionDAL : IBaseDAL<Model.RolePermission>
    {
    }

	public partial interface ISubsectionDAL : IBaseDAL<Model.Subsection>
    {
    }

	public partial interface IUserDBDAL : IBaseDAL<Model.UserDB>
    {
    }

	public partial interface IUserRoleDAL : IBaseDAL<Model.UserRole>
    {
    }

	public partial interface IVipUserPermissionDAL : IBaseDAL<Model.VipUserPermission>
    {
    }

	public partial interface IVolumeDAL : IBaseDAL<Model.Volume>
    {
    }


}