using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class PropertyDescriptor
    {
        public PropertyDescriptor()
        {
            PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags = new HashSet<PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags>();
            PropertyValue = new HashSet<PropertyValue>();
        }

        public Guid Oid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags> PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags { get; set; }
        public virtual ICollection<PropertyValue> PropertyValue { get; set; }
    }
}
