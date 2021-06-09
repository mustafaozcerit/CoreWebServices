using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.test3
{
    public partial class ServerPrefix
    {
        public int Oid { get; set; }
        public string Prefix { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
