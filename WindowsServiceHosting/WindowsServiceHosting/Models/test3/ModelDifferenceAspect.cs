using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class ModelDifferenceAspect
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string Xml { get; set; }
        public Guid? Owner { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ModelDifference OwnerNavigation { get; set; }
    }
}
