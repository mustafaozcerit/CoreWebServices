using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class XtraReportData
    {
        public int Oid { get; set; }
        public string ObjectTypeName { get; set; }
        public byte[] Content { get; set; }
        public string Name { get; set; }
        public string ParametersObjectTypeName { get; set; }
        public bool? IsInplaceReport { get; set; }
        public string PredefinedReportType { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
