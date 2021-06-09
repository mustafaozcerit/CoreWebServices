using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class ModelDifference
    {
        public ModelDifference()
        {
            ModelDifferenceAspect = new HashSet<ModelDifferenceAspect>();
        }

        public Guid Oid { get; set; }
        public string UserId { get; set; }
        public string ContextId { get; set; }
        public int? Version { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<ModelDifferenceAspect> ModelDifferenceAspect { get; set; }
    }
}
