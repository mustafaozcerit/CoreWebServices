using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class XpweakReference
    {
        public XpweakReference()
        {
            AuditDataItemPersistentNewObjectNavigation = new HashSet<AuditDataItemPersistent>();
            AuditDataItemPersistentOldObjectNavigation = new HashSet<AuditDataItemPersistent>();
            PropertyValue = new HashSet<PropertyValue>();
        }

        public Guid Oid { get; set; }
        public int? TargetType { get; set; }
        public string TargetKey { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }

        public virtual XpobjectType ObjectTypeNavigation { get; set; }
        public virtual XpobjectType TargetTypeNavigation { get; set; }
        public virtual AuditedObjectWeakReference AuditedObjectWeakReference { get; set; }
        public virtual ICollection<AuditDataItemPersistent> AuditDataItemPersistentNewObjectNavigation { get; set; }
        public virtual ICollection<AuditDataItemPersistent> AuditDataItemPersistentOldObjectNavigation { get; set; }
        public virtual ICollection<PropertyValue> PropertyValue { get; set; }
    }
}
