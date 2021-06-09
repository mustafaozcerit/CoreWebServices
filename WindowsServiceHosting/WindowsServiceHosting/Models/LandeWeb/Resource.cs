using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class Resource
    {
        public Resource()
        {
            ResourceResourcesEventEvents = new HashSet<ResourceResourcesEventEvents>();
        }

        public Guid Oid { get; set; }
        public string Caption { get; set; }
        public int? Color { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<ResourceResourcesEventEvents> ResourceResourcesEventEvents { get; set; }
    }
}
