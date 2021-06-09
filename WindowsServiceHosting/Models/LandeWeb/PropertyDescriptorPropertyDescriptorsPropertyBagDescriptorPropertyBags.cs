using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class PropertyDescriptorPropertyDescriptorsPropertyBagDescriptorPropertyBags
    {
        public Guid? PropertyBags { get; set; }
        public Guid? PropertyDescriptors { get; set; }
        public Guid Oid { get; set; }
        public int? OptimisticLockField { get; set; }

        public virtual PropertyBagDescriptor PropertyBagsNavigation { get; set; }
        public virtual PropertyDescriptor PropertyDescriptorsNavigation { get; set; }
    }
}
