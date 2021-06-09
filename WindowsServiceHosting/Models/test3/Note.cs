using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class Note
    {
        public Guid Oid { get; set; }
        public string Author { get; set; }
        public DateTime? DateTime { get; set; }
        public string Text { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
