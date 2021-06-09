using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class XpoTrackingRecord
    {
        public int Oid { get; set; }
        public Guid? InstanceId { get; set; }
        public DateTime? DateTime { get; set; }
        public string Data { get; set; }
        public string ActivityId { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
