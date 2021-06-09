using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class ReportData
    {
        public int Oid { get; set; }
        public string ObjectTypeName { get; set; }
        public byte[] Content { get; set; }
        public string Name { get; set; }
        public bool? IsInplaceReport { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
