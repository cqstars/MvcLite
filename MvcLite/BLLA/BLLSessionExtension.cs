
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBLL;

namespace BLLA
{
	public partial class BLLSession:IBLL.IBLLSession
    {
		#region 01 业务接口 IDepartmentDAL
		IDepartmentBLL iDepartmentBLL;
		public IDepartmentBLL IDepartmentBLL
		{
			get
			{
				if(iDepartmentBLL==null)
					iDepartmentBLL= new Department();
				return iDepartmentBLL;
			}
			set
			{
				iDepartmentBLL= value;
			}
		}
		#endregion

		#region 02 业务接口 IPermissionDAL
		IPermissionBLL iPermissionBLL;
		public IPermissionBLL IPermissionBLL
		{
			get
			{
				if(iPermissionBLL==null)
					iPermissionBLL= new Permission();
				return iPermissionBLL;
			}
			set
			{
				iPermissionBLL= value;
			}
		}
		#endregion

		#region 03 业务接口 IPoetDAL
		IPoetBLL iPoetBLL;
		public IPoetBLL IPoetBLL
		{
			get
			{
				if(iPoetBLL==null)
					iPoetBLL= new Poet();
				return iPoetBLL;
			}
			set
			{
				iPoetBLL= value;
			}
		}
		#endregion

		#region 04 业务接口 IPoetryDAL
		IPoetryBLL iPoetryBLL;
		public IPoetryBLL IPoetryBLL
		{
			get
			{
				if(iPoetryBLL==null)
					iPoetryBLL= new Poetry();
				return iPoetryBLL;
			}
			set
			{
				iPoetryBLL= value;
			}
		}
		#endregion

		#region 05 业务接口 IRoleDAL
		IRoleBLL iRoleBLL;
		public IRoleBLL IRoleBLL
		{
			get
			{
				if(iRoleBLL==null)
					iRoleBLL= new Role();
				return iRoleBLL;
			}
			set
			{
				iRoleBLL= value;
			}
		}
		#endregion

		#region 06 业务接口 IRolePermissionDAL
		IRolePermissionBLL iRolePermissionBLL;
		public IRolePermissionBLL IRolePermissionBLL
		{
			get
			{
				if(iRolePermissionBLL==null)
					iRolePermissionBLL= new RolePermission();
				return iRolePermissionBLL;
			}
			set
			{
				iRolePermissionBLL= value;
			}
		}
		#endregion

		#region 07 业务接口 ISubsectionDAL
		ISubsectionBLL iSubsectionBLL;
		public ISubsectionBLL ISubsectionBLL
		{
			get
			{
				if(iSubsectionBLL==null)
					iSubsectionBLL= new Subsection();
				return iSubsectionBLL;
			}
			set
			{
				iSubsectionBLL= value;
			}
		}
		#endregion

		#region 08 业务接口 IUserDBDAL
		IUserDBBLL iUserDBBLL;
		public IUserDBBLL IUserDBBLL
		{
			get
			{
				if(iUserDBBLL==null)
					iUserDBBLL= new UserDB();
				return iUserDBBLL;
			}
			set
			{
				iUserDBBLL= value;
			}
		}
		#endregion

		#region 09 业务接口 IUserRoleDAL
		IUserRoleBLL iUserRoleBLL;
		public IUserRoleBLL IUserRoleBLL
		{
			get
			{
				if(iUserRoleBLL==null)
					iUserRoleBLL= new UserRole();
				return iUserRoleBLL;
			}
			set
			{
				iUserRoleBLL= value;
			}
		}
		#endregion

		#region 10 业务接口 IVipUserPermissionDAL
		IVipUserPermissionBLL iVipUserPermissionBLL;
		public IVipUserPermissionBLL IVipUserPermissionBLL
		{
			get
			{
				if(iVipUserPermissionBLL==null)
					iVipUserPermissionBLL= new VipUserPermission();
				return iVipUserPermissionBLL;
			}
			set
			{
				iVipUserPermissionBLL= value;
			}
		}
		#endregion

		#region 11 业务接口 IVolumeDAL
		IVolumeBLL iVolumeBLL;
		public IVolumeBLL IVolumeBLL
		{
			get
			{
				if(iVolumeBLL==null)
					iVolumeBLL= new Volume();
				return iVolumeBLL;
			}
			set
			{
				iVolumeBLL= value;
			}
		}
		#endregion

    }

}