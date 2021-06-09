using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class IdgeneratorTable
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Prefix { get; set; }
        public int? Oid { get; set; }
        public int? OptimisticLockField { get; set; }
    }
}
