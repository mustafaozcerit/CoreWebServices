using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class SecuritySystemRole
    {
        public SecuritySystemRole()
        {
            SecuritySystemRoleParentRolesSecuritySystemRoleChildRolesChildRolesNavigation = new HashSet<SecuritySystemRoleParentRolesSecuritySystemRoleChildRoles>();
            SecuritySystemRoleParentRolesSecuritySystemRoleChildRolesParentRolesNavigation = new HashSet<SecuritySystemRoleParentRolesSecuritySystemRoleChildRoles>();
            SecuritySystemTypePermissionsObject = new HashSet<SecuritySystemTypePermissionsObject>();
            SecuritySystemUserUsersSecuritySystemRoleRoles = new HashSet<SecuritySystemUserUsersSecuritySystemRoleRoles>();
        }

        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }
        public string Name { get; set; }
        public bool? IsAdministrative { get; set; }
        public bool? CanEditModel { get; set; }

        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual ICollection<SecuritySystemRoleParentRolesSecuritySystemRoleChildRoles> SecuritySystemRoleParentRolesSecuritySystemRoleChildRolesChildRolesNavigation { get; set; }
        public virtual ICollection<SecuritySystemRoleParentRolesSecuritySystemRoleChildRoles> SecuritySystemRoleParentRolesSecuritySystemRoleChildRolesParentRolesNavigation { get; set; }
        public virtual ICollection<SecuritySystemTypePermissionsObject> SecuritySystemTypePermissionsObject { get; set; }
        public virtual ICollection<SecuritySystemUserUsersSecuritySystemRoleRoles> SecuritySystemUserUsersSecuritySystemRoleRoles { get; set; }
    }
}
