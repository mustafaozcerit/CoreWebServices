using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class PropertyBagDescriptor
    {
        public PropertyBagDescriptor()
        {
            PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags = new HashSet<PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags>();
        }

        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags> PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags { get; set; }
    }
}
