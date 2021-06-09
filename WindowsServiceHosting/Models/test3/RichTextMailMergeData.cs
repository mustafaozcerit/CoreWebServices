using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class RichTextMailMergeData
    {
        public Guid Oid { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public byte[] Template { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
