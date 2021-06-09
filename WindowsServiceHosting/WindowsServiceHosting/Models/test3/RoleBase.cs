using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class RoleBase
    {
        public RoleBase()
        {
            PersistentPermission = new HashSet<PersistentPermission>();
        }

        public Guid Oid { get; set; }
        public string Name { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }

        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<PersistentPermission> PersistentPermission { get; set; }
    }
}
