using System;
using System.Collections.Generic;

namespace WindowsServiceHosting.Models.LandeWeb
{
    public partial class OtoKodTanim
    {
        public Guid Oid { get; set; }
        public string ObjeAdi { get; set; }
        public string ObjectType { get; set; }
        public string KodOnTanim { get; set; }
        public int? Uzunluk { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
    }
}
