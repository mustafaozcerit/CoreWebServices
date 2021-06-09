using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class XpoWorkflowInstance
    {
        public int Oid { get; set; }
        public string Owner { get; set; }
        public Guid? InstanceId { get; set; }
        public int? Status { get; set; }
        public string Content { get; set; }
        public string Metadata { get; set; }
        public DateTime? ExpirationDateTime { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
