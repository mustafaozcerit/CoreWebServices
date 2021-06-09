using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class AuditDataItemPersistent
    {
        public Guid Oid { get; set; }
        public string UserName { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string OperationType { get; set; }
        public string Description { get; set; }
        public Guid? AuditedObject { get; set; }
        public Guid? OldObject { get; set; }
        public Guid? NewObject { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string PropertyName { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual AuditedObjectWeakReference AuditedObjectNavigation { get; set; }
        public virtual XpweakReference NewObjectNavigation { get; set; }
        public virtual XpweakReference OldObjectNavigation { get; set; }
    }
}
