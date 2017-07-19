
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
		IRoleBLL IRoleBLL{get;set;}
		IRolePermissionBLL IRolePermissionBLL{get;set;}
		IUserDBBLL IUserDBBLL{get;set;}
		IUserRoleBLL IUserRoleBLL{get;set;}
		IVipUserPermissionBLL IVipUserPermissionBLL{get;set;}
    }

}