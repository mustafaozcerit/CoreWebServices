using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class PersistentPermission
    {
        public Guid Oid { get; set; }
        public string SerializedPermission { get; set; }
        public Guid? Role { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual RoleBase RoleNavigation { get; set; }
    }
}
