using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class XpoStartWorkflowRequest
    {
        public Guid Oid { get; set; }
        public string TargetWorkflowUniqueId { get; set; }
        public string TargetObjectKey { get; set; }
        public string TargetObjectType { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
