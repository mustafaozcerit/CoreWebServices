using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class PermissionPolicyObjectPermissionsObject
    {
        public Guid Oid { get; set; }
        public string Criteria { get; set; }
        public int? ReadState { get; set; }
        public int? WriteState { get; set; }
        public int? DeleteState { get; set; }
        public int? NavigateState { get; set; }
        public Guid? TypePermissionObject { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual PermissionPolicyTypePermissionsObject TypePermissionObjectNavigation { get; set; }
    }
}
