using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Security;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using dxT880319.Module.BusinessObjects;

namespace YourNameSpace {
	public class RoleUpdater : ModuleUpdater {
		public RoleUpdater(IObjectSpace objectSpace, Version currentDBVersion) :
			base(objectSpace, currentDBVersion) {
		}
		public override void UpdateDatabaseAfterUpdateSchema() {
			base.UpdateDatabaseAfterUpdateSchema();
			CreateAdministratorRole();
			CreateUsersRole();
			ObjectSpace.CommitChanges();
		}
		public void CreateAdministratorRole() {
			PermissionPolicyRole role = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Administrator"));
			if(role == null) {
				role = ObjectSpace.CreateObject<PermissionPolicyRole>();
				role.Name = "Administrator";
				role.PermissionPolicy = SecurityPermissionPolicy.DenyAllByDefault;
				role.IsAdministrative = true;
			}
		}
		public void CreateUsersRole() {
			PermissionPolicyRole role = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Users"));
			if(role == null) {
				role = ObjectSpace.CreateObject<PermissionPolicyRole>();
				role.Name = "Users";
				role.PermissionPolicy = SecurityPermissionPolicy.DenyAllByDefault;
				role.AddTypePermission<Contact>(SecurityOperations.FullAccess, SecurityPermissionState.Allow);
				role.AddTypePermission<PermissionPolicyUser>(SecurityOperations.FullAccess, SecurityPermissionState.Deny);
				role.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.ReadOnlyAccess, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
				role.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "StoredPassword", null, SecurityPermissionState.Allow);
				role.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "ChangePasswordOnFirstLogon", null, SecurityPermissionState.Allow);
				role.AddTypePermission<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Allow);
				role.AddTypePermission<PermissionPolicyRole>("Write;Create;Delete;Navigate", SecurityPermissionState.Deny);
				role.AddTypePermission<PermissionPolicyTypePermissionObject>(SecurityOperations.Read, SecurityPermissionState.Allow);
				role.AddNavigationPermission(@"Application/NavigationItems/Items/Default/Items/Contact_ListView", SecurityPermissionState.Allow);
			}
		}
	}
}
