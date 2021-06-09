using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class AuditedObjectWeakReference
    {
        public AuditedObjectWeakReference()
        {
            AuditDataItemPersistent = new HashSet<AuditDataItemPersistent>();
        }

        public Guid Oid { get; set; }
        public Guid? GuidId { get; set; }
        public int? IntId { get; set; }
        public string DisplayName { get; set; }

        public virtual XpweakReference O { get; set; }
        public virtual ICollection<AuditDataItemPersistent> AuditDataItemPersistent { get; set; }
    }
}
