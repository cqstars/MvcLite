
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
	public partial interface IDBSession
    {
		IDepartmentDAL IDepartmentDAL{get;set;}
		IPermissionDAL IPermissionDAL{get;set;}
		IRoleDAL IRoleDAL{get;set;}
		IRolePermissionDAL IRolePermissionDAL{get;set;}
		IUserDBDAL IUserDBDAL{get;set;}
		IUserRoleDAL IUserRoleDAL{get;set;}
		IVipUserPermissionDAL IVipUserPermissionDAL{get;set;}
    }

}