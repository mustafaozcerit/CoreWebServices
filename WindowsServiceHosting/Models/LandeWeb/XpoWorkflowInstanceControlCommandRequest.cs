using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class XpoWorkflowInstanceControlCommandRequest
    {
        public Guid Oid { get; set; }
        public string TargetWorkflowUniqueId { get; set; }
        public Guid? TargetActivityInstanceId { get; set; }
        public int? Command { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Result { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
