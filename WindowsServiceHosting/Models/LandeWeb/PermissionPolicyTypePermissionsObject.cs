using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class PermissionPolicyTypePermissionsObject
    {
        public PermissionPolicyTypePermissionsObject()
        {
            PermissionPolicyMemberPermissionsObject = new HashSet<PermissionPolicyMemberPermissionsObject>();
            PermissionPolicyObjectPermissionsObject = new HashSet<PermissionPolicyObjectPermissionsObject>();
        }

        public Guid Oid { get; set; }
        public Guid? Role { get; set; }
        public string TargetType { get; set; }
        public int? ReadState { get; set; }
        public int? WriteState { get; set; }
        public int? CreateState { get; set; }
        public int? DeleteState { get; set; }
        public int? NavigateState { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual PermissionPolicyRole RoleNavigation { get; set; }
        public virtual ICollection<PermissionPolicyMemberPermissionsObject> PermissionPolicyMemberPermissionsObject { get; set; }
        public virtual ICollection<PermissionPolicyObjectPermissionsObject> PermissionPolicyObjectPermissionsObject { get; set; }
    }
}
