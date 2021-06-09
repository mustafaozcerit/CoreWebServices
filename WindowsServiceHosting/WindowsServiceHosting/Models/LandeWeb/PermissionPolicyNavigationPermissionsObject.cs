using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class PermissionPolicyNavigationPermissionsObject
    {
        public Guid Oid { get; set; }
        public string ItemPath { get; set; }
        public int? NavigateState { get; set; }
        public Guid? Role { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual PermissionPolicyRole RoleNavigation { get; set; }
    }
}
