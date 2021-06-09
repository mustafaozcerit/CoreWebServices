using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class MediaDataObject
    {
        public Guid Oid { get; set; }
        public byte[] MediaData { get; set; }
        public string MediaDataKey { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }

        public virtual XpobjectType ObjectTypeNavigation { get; set; }
    }
}
