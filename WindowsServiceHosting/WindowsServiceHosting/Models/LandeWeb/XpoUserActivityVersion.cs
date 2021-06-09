using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class XpoUserActivityVersion
    {
        public Guid Oid { get; set; }
        public string WorkflowUniqueId { get; set; }
        public string Xaml { get; set; }
        public int? Version { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
