
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;

namespace DALSQL
{
	public partial class DBSession:IDAL.IDBSession
    {
		#region 01 数据接口 IDepartmentDAL
		IDepartmentDAL iDepartmentDAL;
		public IDepartmentDAL IDepartmentDAL
		{
			get
			{
				if(iDepartmentDAL==null)
					iDepartmentDAL= new DepartmentDAL();
				return iDepartmentDAL;
			}
			set
			{
				iDepartmentDAL= value;
			}
		}
		#endregion

		#region 02 数据接口 IPermissionDAL
		IPermissionDAL iPermissionDAL;
		public IPermissionDAL IPermissionDAL
		{
			get
			{
				if(iPermissionDAL==null)
					iPermissionDAL= new PermissionDAL();
				return iPermissionDAL;
			}
			set
			{
				iPermissionDAL= value;
			}
		}
		#endregion

		#region 03 数据接口 IRoleDAL
		IRoleDAL iRoleDAL;
		public IRoleDAL IRoleDAL
		{
			get
			{
				if(iRoleDAL==null)
					iRoleDAL= new RoleDAL();
				return iRoleDAL;
			}
			set
			{
				iRoleDAL= value;
			}
		}
		#endregion

		#region 04 数据接口 IRolePermissionDAL
		IRolePermissionDAL iRolePermissionDAL;
		public IRolePermissionDAL IRolePermissionDAL
		{
			get
			{
				if(iRolePermissionDAL==null)
					iRolePermissionDAL= new RolePermissionDAL();
				return iRolePermissionDAL;
			}
			set
			{
				iRolePermissionDAL= value;
			}
		}
		#endregion

		#region 05 数据接口 IUserDBDAL
		IUserDBDAL iUserDBDAL;
		public IUserDBDAL IUserDBDAL
		{
			get
			{
				if(iUserDBDAL==null)
					iUserDBDAL= new UserDBDAL();
				return iUserDBDAL;
			}
			set
			{
				iUserDBDAL= value;
			}
		}
		#endregion

		#region 06 数据接口 IUserRoleDAL
		IUserRoleDAL iUserRoleDAL;
		public IUserRoleDAL IUserRoleDAL
		{
			get
			{
				if(iUserRoleDAL==null)
					iUserRoleDAL= new UserRoleDAL();
				return iUserRoleDAL;
			}
			set
			{
				iUserRoleDAL= value;
			}
		}
		#endregion

		#region 07 数据接口 IVipUserPermissionDAL
		IVipUserPermissionDAL iVipUserPermissionDAL;
		public IVipUserPermissionDAL IVipUserPermissionDAL
		{
			get
			{
				if(iVipUserPermissionDAL==null)
					iVipUserPermissionDAL= new VipUserPermissionDAL();
				return iVipUserPermissionDAL;
			}
			set
			{
				iVipUserPermissionDAL= value;
			}
		}
		#endregion

    }

}