using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class PropertyBag
    {
        public PropertyBag()
        {
            PropertyValue = new HashSet<PropertyValue>();
        }

        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<PropertyValue> PropertyValue { get; set; }
    }
}
