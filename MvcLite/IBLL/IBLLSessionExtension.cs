
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBLL
{
	public partial interface IBLLSession
    {
		IDepartmentBLL IDepartmentBLL{get;set;}
		IPermissionBLL IPermissionBLL{get;set;}
		IPoetBLL IPoetBLL{get;set;}
		IPoetryBLL IPoetryBLL{get;set;}
		IRoleBLL IRoleBLL{get;set;}
		IRolePermissionBLL IRolePermissionBLL{get;set;}
		ISubsectionBLL ISubsectionBLL{get;set;}
		IUserDBBLL IUserDBBLL{get;set;}
		IUserRoleBLL IUserRoleBLL{get;set;}
		IVipUserPermissionBLL IVipUserPermissionBLL{get;set;}
		IVolumeBLL IVolumeBLL{get;set;}
    }

}